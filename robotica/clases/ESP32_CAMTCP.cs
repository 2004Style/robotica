using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System;

namespace robotica.clases
{
    public class ESP32_CAMTCP
    {
        private string IP_Esp32Cam = "192.168.50.71";
        private int Port_Esp32Cam = 81;

        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private PictureBox pictureBox;
        private CancellationTokenSource cancellationTokenSource; // Para cancelar el hilo de recepción
        private volatile bool isReceiving = false; // Flag para controlar el ciclo de recepción

        private bool disconect = false;
        public ESP32_CAMTCP(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void StartReceiving()
        {
            StopReceiving(); // Detener cualquier recepción previa antes de iniciar una nueva

            try
            {
                // Intentar establecer la conexión con el servidor ESP32-CAM
                client = new TcpClient(IP_Esp32Cam, Port_Esp32Cam); // Conexión al servidor

                // Verificar si la conexión fue exitosa
                if (client.Connected)
                {
                    disconect = false;//variable para que pueda reconectarce siempre y cuando no llame al metodo desconectar
                    
                    
                    stream = client.GetStream(); // Obtener el flujo de datos
                    isReceiving = true;
                    cancellationTokenSource = new CancellationTokenSource(); // Crear el CancellationTokenSource

                    // Inicializar el hilo para recibir imágenes
                    receiveThread = new Thread(() => ReceiveImages(cancellationTokenSource.Token));
                    receiveThread.IsBackground = true; // Hilo en segundo plano
                    receiveThread.Start();
                    Console.WriteLine("Conexión exitosa y recepción de imágenes iniciada.");
                }
                else
                {
                    Console.WriteLine("No se pudo conectar al servidor.");
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine("Error de red o servidor inaccesible: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }

        private void ReceiveImages(CancellationToken cancellationToken)
        {
            byte[] lengthBuffer = new byte[4]; // Para leer el tamaño de la imagen
            byte[] imageBuffer;

            int bufferSize = 8192; // Tamaño del buffer de lectura (8 KB)
            byte[] tempBuffer = new byte[bufferSize]; // Buffer temporal para la lectura

            while (isReceiving && !cancellationToken.IsCancellationRequested) // Usar el flag y el token de cancelación
            {
                try
                {
                    if (client.Connected)
                    {
                        stream.ReadTimeout = 3000; // Timeout de 3 segundos

                        // Leer el tamaño de la imagen (4 bytes)
                        if (stream.Read(lengthBuffer, 0, 4) == 4)
                        {
                            int imageSize = BitConverter.ToInt32(lengthBuffer, 0);
                            imageBuffer = new byte[imageSize];

                            // Leer la imagen en el buffer
                            int totalRead = 0;
                            while (totalRead < imageSize && !cancellationToken.IsCancellationRequested) // Verificar el token para evitar lecturas innecesarias
                            {
                                int remaining = imageSize - totalRead;
                                int bytesRead = stream.Read(tempBuffer, 0, Math.Min(bufferSize, remaining)); // Leer en el buffer temporal
                                if (bytesRead == 0) break; // Se cerró la conexión

                                Buffer.BlockCopy(tempBuffer, 0, imageBuffer, totalRead, bytesRead); // Copiar los datos leídos al buffer de imagen
                                totalRead += bytesRead; // Actualizar total leído
                            }

                            // Crear el bitmap y actualizar el PictureBox
                            if (totalRead == imageSize && !cancellationToken.IsCancellationRequested) // Verificar si se completó la lectura
                            {
                                using (MemoryStream ms = new MemoryStream(imageBuffer))
                                {
                                    Bitmap bitmap = new Bitmap(ms);
                                    pictureBox.Invoke((MethodInvoker)(() => pictureBox.Image = bitmap)); // Actualiza la imagen en el PictureBox
                                }
                            }
                        }
                    }
                }
                catch (IOException ioEx)
                {
                    Console.WriteLine("Timeout o error de E/S: " + ioEx.Message);
                    pictureBox.Invoke((MethodInvoker)(() => pictureBox.Image = Properties.Resources.logo_convertsystems_con_nombre_sin_fondo_08));

                    // Intentar reconectar
                    Console.WriteLine("Intentando reconectar...");
                    if (!Reconnect())
                    {
                        Console.WriteLine("No se pudo restablecer la conexión.");
                        StopReceiving(); // Detener si la reconexión falla
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al recibir la imagen: " + ex.Message);
                    pictureBox.Invoke((MethodInvoker)(() => pictureBox.Image = Properties.Resources.logo_convertsystems_con_nombre_sin_fondo_08));
                    StopReceiving(); // Detener en caso de error
                    StartReceiving();
                }
            }
        }
        private bool Reconnect()
        {
            try
            {
                if (!disconect)
                {
                    client.Close(); // Cerrar la conexión actual
                    client = new TcpClient(IP_Esp32Cam, Port_Esp32Cam); // Intentar reconectar
                    if (client.Connected)
                    {
                        stream = client.GetStream(); // Restablecer el flujo de datos
                        Console.WriteLine("Reconexión exitosa.");
                        return true; // Reconexión exitosa
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al reconectar: " + ex.Message);
            }

            return false; // Fallo al reconectar
        }

        public void StopReceiving()
        {
            disconect = true;
            // Detener el ciclo de recepción
            isReceiving = false;
            cancellationTokenSource?.Cancel(); // Cancelar el hilo de recepción

            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Join(1000); // Esperar a que el hilo termine con un timeout
                receiveThread = null;
            }

            if (client != null)
            {
                client.Close();
                client = null;
            }

            pictureBox.Invoke((MethodInvoker)(() => pictureBox.Image = Properties.Resources.logo_convertsystems_con_nombre_sin_fondo_08));
            Console.WriteLine("Conexión y recepción detenida.");
        }
    }
}

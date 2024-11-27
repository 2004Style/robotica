using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace robotica.clases
{
    public class ESP32_CAMTCP
    {
        public string IP_Esp32Cam;
        public int Port_Esp32Cam;

        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        public PictureBox pictureBox; // Referencia al PictureBox para mostrar la imagen

        public void StartReceiving()
        {
            //client = new TcpClient("192.168.67.71", 81); // Conexión al servidor
            client = new TcpClient(IP_Esp32Cam, Port_Esp32Cam); // Conexión al servidor
            stream = client.GetStream();
            receiveThread = new Thread(ReceiveImages);
            receiveThread.IsBackground = true; // Hilo en segundo plano
            receiveThread.Start();
        }

        private void ReceiveImages()
        {
            byte[] lengthBuffer = new byte[4]; // Para leer el tamaño de la imagen
            byte[] imageBuffer;

            while (client.Connected)
            {
                try
                {
                    // Leer el tamaño de la imagen (4 bytes)
                    if (stream.Read(lengthBuffer, 0, 4) == 4)
                    {
                        int imageSize = BitConverter.ToInt32(lengthBuffer, 0);
                        imageBuffer = new byte[imageSize];

                        // Leer la imagen en el buffer
                        int totalRead = 0;
                        while (totalRead < imageSize)
                        {
                            int bytesRead = stream.Read(imageBuffer, totalRead, imageSize - totalRead);
                            if (bytesRead == 0) break; // Se cerró la conexión
                            totalRead += bytesRead;
                        }

                        // Crear el bitmap y actualizar el PictureBox
                        using (MemoryStream ms = new MemoryStream(imageBuffer))
                        {
                            Bitmap bitmap = new Bitmap(ms);
                            pictureBox.Invoke((MethodInvoker)(() => pictureBox.Image = bitmap)); // Actualiza la imagen en el PictureBox
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al recibir la imagen: " + ex.Message);
                    break;
                }
            }
        }


        public void StopReceiving()
        {
            if (client != null)
            {
                client.Close();
            }
            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Abort();
            }
        }

    }
}

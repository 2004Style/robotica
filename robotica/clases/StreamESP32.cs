using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace robotica.clases
{
    public class StreamESP32
    {
        private string streamUrl = "http://192.168.67.71/stream"; // Dirección IP del ESP32-CAM
        public bool isStreaming = false;

        public async void StartStream(PictureBox pictureBox)
        {
            isStreaming = true;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(streamUrl);
                request.Timeout = 10000;  // Timeout de 10 segundos
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();

                if (!response.ContentType.StartsWith("multipart/x-mixed-replace"))
                {
                    MessageBox.Show("Tipo de contenido no soportado: " + response.ContentType);
                    return;
                }

                Stream stream = response.GetResponseStream();
                byte[] buffer = new byte[16384];  // Buffer de tamaño adecuado
                int bytesRead = 0;
                int imageStartIndex = 0;

                while (isStreaming)
                {
                    try
                    {
                        bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                        if (bytesRead > 0)
                        {
                            // Busca el inicio y fin de la imagen JPEG
                            for (int i = 0; i < bytesRead - 1; i++)
                            {
                                // Detectar inicio de imagen (0xFFD8)
                                if (buffer[i] == 0xFF && buffer[i + 1] == 0xD8)
                                {
                                    imageStartIndex = i; // Almacena el índice de inicio
                                                         // Busca el final de la imagen (0xFFD9)
                                    for (int j = i; j < bytesRead - 1; j++)
                                    {
                                        if (buffer[j] == 0xFF && buffer[j + 1] == 0xD9)
                                        {
                                            // Crea la imagen desde el flujo directamente
                                            int imageLength = j + 2 - imageStartIndex;
                                            using (var imgStream = new MemoryStream(buffer, imageStartIndex, imageLength))
                                            {
                                                pictureBox.Invoke((Action)(() =>
                                                {
                                                    pictureBox.Image = new Bitmap(imgStream);
                                                }));
                                            }
                                            i = j + 1; // Avanza el índice para continuar la búsqueda
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("El flujo de datos se detuvo o está incompleto.");
                        }
                    }
                    catch (Exception streamEx)
                    {
                        Console.WriteLine("Error al procesar el flujo de la cámara: " + streamEx.Message);
                        isStreaming = false;  // Detener el stream en caso de error
                    }
                }
            }
            catch (WebException webEx)
            {
                MessageBox.Show("Error al conectar con la cámara: " + webEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
            finally
            {
                isStreaming = false;
            }
        }






















    }
}

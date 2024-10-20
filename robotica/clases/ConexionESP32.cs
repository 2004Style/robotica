using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robotica.clases
{
    public class ConexionESP32
    {

        StreamESP32 StreamESP32 = new StreamESP32();

        private ESP32_CAMTCP Esp32Cam = new ESP32_CAMTCP();

        public string IP_Esp32DevKit;
        public int Port_Esp32DevKit;

        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;

        public bool conexion_esp32 = true;

        public void conexion(Button btn, Label label, PictureBox camara)
        {
            if (conexion_esp32)
            {
                conexion_esp32 = false;
                try
                {
                    //client = new TcpClient("192.168.67.1", 80);
                    client = new TcpClient(IP_Esp32DevKit, Port_Esp32DevKit);
                    reader = new StreamReader(client.GetStream());
                    writer = new StreamWriter(client.GetStream());
                    writer.AutoFlush = true;
                    string welcomeMessage = reader.ReadLine();
                    label.Text = welcomeMessage;
                    btn.ForeColor = Color.FromArgb(0, 255, 31);
                    btn.Text = " Conectado";
                    btn.Image = Properties.Resources.Conectar_Robot;
                    btn.FlatAppearance.BorderColor = Color.Lime;
                    Properties.Settings.Default.btn_conectar = true;
                    Properties.Settings.Default.Save();


                    //Task.Run(() => StreamESP32.StartStream(camara));
                    //Esp32Cam = new ESP32_CAMTCP(camara);
                    Esp32Cam.StartReceiving();
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error conectando: " + ex.Message);
                }
            }
            else
            {
                conexion_esp32 = true;
                try
                {
                    if (client != null && client.Connected)
                    {
                        writer.Close();
                        reader.Close();
                        client.Close();
                        label.Text = "Desconectado con el robot";
                        btn.Text = " Desconectado";
                        btn.ForeColor = Color.Red;
                        btn.Image = Properties.Resources.Desconectar_Robot;
                        btn.FlatAppearance.BorderColor = Color.Red;
                        Properties.Settings.Default.btn_conectar = false;
                        Properties.Settings.Default.Save();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error de desconectado: " + ex.Message);
                }

            }
        }
        public void enviardatos(string datos)
        {
            if (client != null && client.Connected)
            {
                string message = datos;
                writer.WriteLine(message);
            }
            else
            {
                //MessageBox.Show("No conectado al ESP32.");
            }
        }
        public void CerrarCOnexionESP32()
        {
            if (client != null && client.Connected)
            {
                writer.Close();
                reader.Close();
                client.Close();

                //StreamESP32.isStreaming = false;
                Esp32Cam.StopReceiving();
            }
        }
    }
}

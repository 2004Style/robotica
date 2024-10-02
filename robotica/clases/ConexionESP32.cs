using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace robotica.clases
{
    public class ConexionESP32
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;

        public bool conexion_esp32 = true;

        public void conexion(Button btn, Label label)
        {
            if (conexion_esp32)
            {
                conexion_esp32 = false;
                btn.Text = "Desconectar"; // WPF uses Content instead of Text
                try
                {
                    client = new TcpClient("192.168.79.1", 80);
                    reader = new StreamReader(client.GetStream());
                    writer = new StreamWriter(client.GetStream());
                    writer.AutoFlush = true;
                    string welcomeMessage = reader.ReadLine();
                    label.Text = welcomeMessage; // WPF uses Content instead of Text
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error conectando: " + ex.Message); // WPF MessageBox
                }
            }
            else
            {
                conexion_esp32 = true;
                btn.Text = "Conectar";
                try
                {
                    if (client != null && client.Connected)
                    {
                        writer.Close();
                        reader.Close();
                        client.Close();
                        label.Text = "Desconectado con el robot";
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error de desconectado: " + ex.Message); // WPF MessageBox
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
            }
        }
    }
}

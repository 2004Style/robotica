﻿using robotica.clases;
using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace robotica
{
    public partial class Panel_Control : Form
    {
        //variables para manejar las direcciones del robot
        public String Direccion_robot = null;

        //variables para manejar las la torreta
        public String Direccion_torreta = null;

        //variables para manejar las las luces
        public String Luces_frontales = null;
        public String Luces_traseras = null;

        //variables para los intermitentes
        public String Luces_intermitentes = null;

        public Panel_Control()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        ConexionESP32 ESP32 = new ConexionESP32();
        private void button1_Click(object sender, EventArgs e)
        {
            ESP32.conexion(button1,lbl_conexion_remota);
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            ESP32.CerrarCOnexionESP32();
        }

        public void robot()
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (Direccion_robot != null)
                {
                    ESP32.enviardatos($"Direccion_robot={Direccion_robot}");
                }
                else
                {
                    ESP32.enviardatos("Direccion_robot=STOP");
                }
            }
            else
            {
                MessageBox.Show("conexion no establecida");
            }
        }

        #region controles de robot

        public void R_forward(string dato)
        {
            Direccion_robot = dato;
            robot();
        }
        public void R_back(string dato)
        {
            Direccion_robot = dato;
            robot();
        }
        public void R_right(string dato)
        {
            Direccion_robot = dato;
            robot();
        }
        public void R_left(string dato)
        {
            Direccion_robot = dato;
            robot();
        }

        private void btn_robot_avanzar_MouseDown(object sender, MouseEventArgs e)
        {
            R_forward("R_Forward");
        }

        private void btn_robot_avanzar_MouseUp(object sender, MouseEventArgs e)
        {
            R_forward(null);
        }

        private void btn_robot_izquierda_MouseDown(object sender, MouseEventArgs e)
        {
            R_left("R_Left");
        }

        private void btn_robot_izquierda_MouseUp(object sender, MouseEventArgs e)
        {
            R_left(null);
        }

        private void btn_robot_retroceder_MouseDown(object sender, MouseEventArgs e)
        {
            R_back("R_Back");
        }

        private void btn_robot_retroceder_MouseUp(object sender, MouseEventArgs e)
        {
            R_back(null);
        }

        private void btn_robot_derecha_MouseDown(object sender, MouseEventArgs e)
        {
            R_right("R_Right");
        }

        private void btn_robot_derecha_MouseUp(object sender, MouseEventArgs e)
        {
            R_right(null);
        }
        #endregion controles de robot

        public void torreta()
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (Direccion_torreta != null)
                {
                    ESP32.enviardatos($"Direccion_torreta={Direccion_torreta}");
                }
                else
                {
                    ESP32.enviardatos("Direccion_torreta=STOP");
                }
            }
            else
            {
                MessageBox.Show("conexion no establecida");
            }
        }

        #region controles de riego manual

        public void T_up(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta();
        }
        public void T_down(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta();
        }
        public void T_left(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta();
        }
        public void T_right(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta();
        }
        public void T_reset(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta();
        }


        private void btn_riego_manual_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            T_up("T_up");
        }

        private void btn_riego_manual_arriba_MouseUp(object sender, MouseEventArgs e)
        {
            T_up(null);
        }

        private void btn_riego_manual_izquierda_MouseDown(object sender, MouseEventArgs e)
        {
            T_left("T_left");
        }

        private void btn_riego_manual_izquierda_MouseUp(object sender, MouseEventArgs e)
        {
            T_left(null);
        }

        private void button2btn_riego_manual_abajo_MouseDown(object sender, MouseEventArgs e)
        {
            T_down("T_down");
        }

        private void button2btn_riego_manual_abajo_MouseUp(object sender, MouseEventArgs e)
        {
            T_down(null);
        }

        private void btn_riego_manual_derecha_MouseDown(object sender, MouseEventArgs e)
        {
            T_right("T_right");
        }

        private void btn_riego_manual_derecha_MouseUp(object sender, MouseEventArgs e)
        {
            T_right(null);
        }
        private void btn_restablecer_posicion_torreta_Click(object sender, EventArgs e)
        {
            T_reset("T_reset");
        }
        #endregion controles de riego manual

        //intermitentes
        public bool estado_de_intermitentes = false;

        public void intermitentes()
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (Luces_intermitentes != null)
                {
                    ESP32.enviardatos($"Luces_intermitentes={Luces_intermitentes}");
                }
                else
                {
                    ESP32.enviardatos("Luces_intermitentes=OFF");
                }
            }
            else
            {
                MessageBox.Show("conexion no establecida");
            }

        }
        private void intermitente_izquierdo()
        {
            if (Luces_intermitentes == "I_advertencia")
            {
                return;
            }

            if (Luces_intermitentes == "I_left")
            {
                Luces_intermitentes = null;
                btn_intermitente_izquierdo.BackColor = Color.Teal;
                estado_de_intermitentes = false;
            }
            else
            {
                Luces_intermitentes = "I_left";
                btn_intermitente_izquierdo.BackColor = Color.Lime;
                btn_intermitente_derecho.BackColor = Color.Teal;
                btn_intermitente_advertencia.BackColor = Color.Teal;
                estado_de_intermitentes = true;
            }

            intermitentes();
        }
        private void btn_intermitente_izquierdo_Click(object sender, EventArgs e)
        {
            intermitente_izquierdo();
        }
        private void intermitente_advertencia()
        {
            if (Luces_intermitentes == "I_advertencia")
            {
                Luces_intermitentes = null;
                btn_intermitente_advertencia.BackColor = Color.Teal;
                estado_de_intermitentes = false;
            }
            else
            {
                Luces_intermitentes = "I_advertencia";
                btn_intermitente_advertencia.BackColor = Color.Lime;
                btn_intermitente_derecho.BackColor = Color.Teal;
                btn_intermitente_izquierdo.BackColor = Color.Teal;
                estado_de_intermitentes = true;
            }

            intermitentes();
        }
        private void btn_intermitente_advertencia_Click(object sender, EventArgs e)
        {
            intermitente_advertencia();
        }
        private void intermitente_derecho()
        {
            if (Luces_intermitentes == "I_advertencia")
            {
                return;
            }

            if (Luces_intermitentes == "I_right")
            {
                Luces_intermitentes = null;
                btn_intermitente_derecho.BackColor = Color.Teal;
                estado_de_intermitentes = false;
            }
            else
            {
                Luces_intermitentes = "I_right";
                btn_intermitente_derecho.BackColor = Color.Lime;
                btn_intermitente_advertencia.BackColor = Color.Teal;
                btn_intermitente_izquierdo.BackColor = Color.Teal;
                estado_de_intermitentes = true;
            }

            intermitentes();
        }
        private void btn_intermitente_derecho_Click(object sender, EventArgs e)
        {
            intermitente_derecho();
        }

        //boton controlador de la luz
        public void luces()
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (Luces_frontales != null)
                {
                    ESP32.enviardatos($"Luces_frontales={Luces_frontales}");
                }
                else
                {
                    ESP32.enviardatos("Luces_frontales=OFF");
                }
            }

            else
            {
                MessageBox.Show("conexion no establecida");
            }
        }
        private bool luzApagada = true;
        public void Luces_Frontales_Tanque()
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (luzApagada)
                {
                    btn_luz.Image = Properties.Resources.luz_apagada;
                    btn_luz.BackColor = Color.Lime;
                    luzApagada = false;
                    Luces_frontales = "LF_ON";
                    luces();
                }
                else
                {
                    btn_luz.Image = Properties.Resources.luz_encendida;
                    btn_luz.BackColor = Color.Teal;
                    luzApagada = true;
                    Luces_frontales = "LF_OFF";
                    luces();
                }
            }

            else
            {
                MessageBox.Show("conexion no establecida");
            }
        }
        private void btn_luz_Click(object sender, EventArgs e)
        {
            Luces_Frontales_Tanque();
        }

        // configuraciones
        private bool ecape_KeyPressed = false;
        // robot
        private bool w_KeyPressed = false;
        private bool s_KeyPressed = false;
        private bool a_KeyPressed = false;
        private bool d_KeyPressed = false;
        //torreta
        private bool i_KeyPressed = false;
        private bool k_KeyPressed = false;
        private bool l_KeyPressed = false;
        private bool j_KeyPressed = false;
        private bool o_KeyPressed = false;
        //luces
        private bool z_KeyPressed = false;
        //intermitentes
        private bool x_KeyPressed = false;
        private bool c_KeyPressed = false;
        private bool v_KeyPressed = false;
        //conectar
        private bool m_KeyPressed = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string forwardKey = Properties.Settings.Default.R_Folwar;
            string backKey = Properties.Settings.Default.R_Back;
            string leftKey = Properties.Settings.Default.R_Left;
            string rightKey = Properties.Settings.Default.R_Right;
            string upKey = Properties.Settings.Default.T_up;
            string downKey = Properties.Settings.Default.T_Down;
            string rightTorretaKey = Properties.Settings.Default.T_Right;
            string leftTorretaKey = Properties.Settings.Default.T_Left;
            string resetTorretaKey = Properties.Settings.Default.T_Reset;
            string lucesKey = Properties.Settings.Default.Luces;
            string intermitenteIzquierdoKey = Properties.Settings.Default.Intermitente_I;
            string intermitenteAdvertenciaKey = Properties.Settings.Default.Intermitentes_A;
            string intermitenteDerechoKey = Properties.Settings.Default.Intermitente_D;
            string conectarKey = Properties.Settings.Default.Conectar;

            if (e.KeyCode == Keys.Escape && !ecape_KeyPressed)
            {
                ecape_KeyPressed = true;
                this.Visible = false;
                new nav_controller().Visible = true;
            }
            else if (e.KeyCode.ToString() == forwardKey && !w_KeyPressed)
            {
                w_KeyPressed = true;
                R_forward("R_Forward");
                btn_robot_avanzar.BackColor = Color.Lime;
            }
            else if (e.KeyCode.ToString() == backKey && !s_KeyPressed)
            {
                s_KeyPressed = true;
                R_back("R_Back");
                btn_robot_retroceder.BackColor = Color.Lime;
            }
            else if (e.KeyCode.ToString() == leftKey && !a_KeyPressed)
            {
                a_KeyPressed = true;
                R_left("R_Left");
                btn_robot_izquierda.BackColor = Color.Lime;
            }
            else if (e.KeyCode.ToString() == rightKey && !d_KeyPressed)
            {
                d_KeyPressed = true;
                R_right("R_Right");
                btn_robot_derecha.BackColor = Color.Lime;
            }
            else if (e.KeyCode.ToString() == upKey && !i_KeyPressed)
            {
                i_KeyPressed = true;
                T_up("T_up");
                btn_riego_manual_arriba.BackColor = Color.Lime;
                o_KeyPressed = false;
                btn_restablecer_posicion_torreta.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == downKey && !k_KeyPressed)
            {
                k_KeyPressed = true;
                T_down("T_down");
                button2btn_riego_manual_abajo.BackColor = Color.Lime;
                o_KeyPressed = false;
                btn_restablecer_posicion_torreta.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == rightTorretaKey && !l_KeyPressed)
            {
                l_KeyPressed = true;
                T_right("T_right");
                btn_riego_manual_derecha.BackColor = Color.Lime;
                o_KeyPressed = false;
                btn_restablecer_posicion_torreta.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == leftTorretaKey && !j_KeyPressed)
            {
                j_KeyPressed = true;
                T_left("T_left");
                btn_riego_manual_izquierda.BackColor = Color.Lime;
                o_KeyPressed = false;
                btn_restablecer_posicion_torreta.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == resetTorretaKey && !o_KeyPressed)
            {
                o_KeyPressed = true;
                T_left("T_reset");
                btn_restablecer_posicion_torreta.BackColor = Color.Lime;
            }
            else if (e.KeyCode.ToString() == lucesKey && !z_KeyPressed)
            {
                z_KeyPressed = true;
                Luces_Frontales_Tanque();
            }
            else if (e.KeyCode.ToString() == intermitenteIzquierdoKey && !x_KeyPressed)
            {
                x_KeyPressed = true;
                intermitente_izquierdo();
            }
            else if (e.KeyCode.ToString() == intermitenteAdvertenciaKey && !c_KeyPressed)
            {
                c_KeyPressed = true;
                intermitente_advertencia();
            }
            else if (e.KeyCode.ToString() == intermitenteDerechoKey && !v_KeyPressed)
            {
                v_KeyPressed = true;
                intermitente_derecho();
            }
            else if (e.KeyCode.ToString() == conectarKey && !m_KeyPressed)
            {
                m_KeyPressed = true;
                ESP32.conexion(button1, lbl_conexion_remota);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                ecape_KeyPressed = false;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.R_Folwar)
            {
                w_KeyPressed = false;
                R_forward(null);
                btn_robot_avanzar.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.R_Back)
            {
                s_KeyPressed = false;
                R_back(null);
                btn_robot_retroceder.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.R_Left)
            {
                a_KeyPressed = false;
                R_left(null);
                btn_robot_izquierda.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.R_Right)
            {
                d_KeyPressed = false;
                R_right(null);
                btn_robot_derecha.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.T_up)
            {
                i_KeyPressed = false;
                T_up(null);
                btn_riego_manual_arriba.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.T_Down)
            {
                k_KeyPressed = false;
                T_down(null);
                button2btn_riego_manual_abajo.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.T_Right)
            {
                l_KeyPressed = false;
                T_right(null);
                btn_riego_manual_derecha.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.T_Left)
            {
                j_KeyPressed = false;
                T_left(null);
                btn_riego_manual_izquierda.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.T_Reset)
            {
                o_KeyPressed = false;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.Luces)
            {
                z_KeyPressed = false;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.Intermitente_I)
            {
                x_KeyPressed = false;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.Intermitentes_A)
            {
                c_KeyPressed = false;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.Intermitente_D)
            {
                v_KeyPressed = false;
            }
            else if (e.KeyCode.ToString() == Properties.Settings.Default.Conectar)
            {
                m_KeyPressed = false;
            }
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new ConfiguracionDeControles().Visible = true;
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            ESP32.CerrarCOnexionESP32();
            Application.Exit();
        }
    }
}
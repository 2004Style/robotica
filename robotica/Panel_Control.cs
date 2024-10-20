using robotica.clases;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robotica
{
    public partial class Panel_Control : Form
    {
        //StreamESP32 StreamESP32 = new StreamESP32();
        private ESP32_CAMTCP Esp32Cam = new ESP32_CAMTCP();
        private ConexionESP32 ESP32 = new ConexionESP32();


        //variables para manejar las direcciones del robot
        public String Direccion_robot = null;

        //variables para manejar las la torreta
        public String Direccion_torreta = null;

        //variables para manejar las las luces
        public String Luces_frontales = null;
        public String Luces_traseras = null;

        //variables para los intermitentes
        public String Luces_intermitentes = null;

        //variable de sensor de humedad
        public String estado_humedad = null;

        private moverformulario formMover;
        public Panel_Control()
        {
            InitializeComponent();
            ESP32.IP_Esp32DevKit = "192.168.67.1";
            ESP32.Port_Esp32DevKit= 80;

            Esp32Cam.IP_Esp32Cam = "192.168.67.71";
            Esp32Cam.Port_Esp32Cam = 81;
            Esp32Cam.pictureBox = camara;


            ComprobarBtns();
            this.KeyPreview = true;
            formMover = new moverformulario(this, this);
        }

        

        #region conexion del robot y verificacion de estados
        //este metodo se encarga de revisar todas las variables almacenadas de los botones y ver su estado si estan en true o false segun el valor correspondiente se realizaran acciones esto es eficas para el momento de ejecutar la aplicacion
        //ejemplo
        //si la ven anterior que estuvimos en la aplicacion dejamos las luces enecendidas entonces al acceder a la aplicacion este boton estara activado devido a que su valor sera un true caso contrario estaria desactivado esto funciona perfecto para tener sincronizado los valores del robot con la aplicacion ya que si dejamos las luces activadas y no verificamos al abrir la aplicacion nuevamente saldria desactivado cuando en la placa del robot su ultimi order fue que esten activas
        private void ComprobarBtns()
        {
            bool btn_luces = Properties.Settings.Default.btn_luces;
            bool btn_advertencia = Properties.Settings.Default.btn_advertencia;
            bool btn_i_derecho = Properties.Settings.Default.btn_i_derecho;
            bool btn_i_izquierdo = Properties.Settings.Default.btn_i_izquierdo;
            bool btn_activar_s_humedad = Properties.Settings.Default.btn_activar_s_humedad;
            bool btn_conectar = Properties.Settings.Default.btn_conectar;
            //Properties.Settings.Default.Save();

            if (btn_luces == true)
            {
                btn_luz.Image = Properties.Resources.luz_encendida;
                btn_luz.FlatAppearance.BorderColor = Color.Lime;
                luzApagada = false;
            }
            else
            {
                btn_luz.Image = Properties.Resources.luz_apagada;
                btn_luz.FlatAppearance.BorderColor = Color.Red;
                luzApagada = true;
            }
            if (btn_advertencia == true)
            {
                btn_intermitente_advertencia.Image = Properties.Resources.advertencia_encendido;
                btn_intermitente_advertencia.FlatAppearance.BorderColor = Color.Lime;
            }
            else
            {
                btn_intermitente_advertencia.Image = Properties.Resources.advertencia_apagado;
                btn_intermitente_advertencia.FlatAppearance.BorderColor = Color.Red;
            }
            if (btn_i_derecho == true)
            {
                btn_intermitente_derecho.Image = Properties.Resources.intermitente_derecha_encendido;
                btn_intermitente_derecho.FlatAppearance.BorderColor = Color.Lime;
            }
            else
            {
                btn_intermitente_derecho.Image = Properties.Resources.intermitente_derecha_apagado;
                btn_intermitente_derecho.FlatAppearance.BorderColor = Color.Red;
            }
            if (btn_i_izquierdo == true)
            {
                btn_intermitente_izquierdo.Image = Properties.Resources.intermitente_izquierda_encendido;
                btn_intermitente_izquierdo.FlatAppearance.BorderColor = Color.Lime;
            }
            else
            {
                btn_intermitente_izquierdo.Image = Properties.Resources.intermitente_izquierda_apagado;
                btn_intermitente_izquierdo.FlatAppearance.BorderColor = Color.Red;
            }
            if (btn_activar_s_humedad == true)
            {
                btn_Humedad.Image = Properties.Resources.Humedad_activado;
                btn_Humedad.FlatAppearance.BorderColor = Color.Lime;
            }
            else
            {
                btn_Humedad.Image = Properties.Resources.Humedad_inactivo;
                btn_Humedad.FlatAppearance.BorderColor = Color.Red;
            }
            if (btn_conectar == true)
            {
                button1.Image = Properties.Resources.Conectar_Robot;
                button1.FlatAppearance.BorderColor = Color.Lime;
                ESP32.conexion(button1, lbl_conexion_remota, camara);
            }
            else
            {
                button1.Image = Properties.Resources.Desconectar_Robot;
                button1.FlatAppearance.BorderColor = Color.Red;
            }
        }
        //boton para establecer la conexion con el robot
        private void button1_Click(object sender, EventArgs e)
        {
            ESP32.conexion(button1,lbl_conexion_remota,camara);
        }
        //acciones que suceden cuendo el formulario se cierra
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.btn_conectar = false;
            ESP32.CerrarCOnexionESP32();
        }

        private void Panel_Control_Load(object sender, EventArgs e)
        {
            //Esp32Cam = new ESP32_CAMTCP(camara);
            //Esp32Cam.StartReceiving(); // Reemplaza con la IP de tu ESP32
        }



        //acciones que pasan cuando el boton de configuracion es accionado => en este caso se encarga de cerrar la conexion con el esp32 para que al regresar al panel de control no haya errores de conexion con el robot
        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            ESP32.CerrarCOnexionESP32();
            this.Visible = false;
            new nav_controller().Visible = true;
        }
        //acciones del boton cerrar => en este caso nos encargamos de cerrar la conexion con el robot a parte de que la propiedad almacenada del boton conectar la establecemos a falso para que cuando abramos nuevamente la aplicacion la conexion no se aga automaticamente sino que debemos accionar el boton de conexion para que recien solicite acceso de conexion al robot
        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.btn_conectar = false;
            Properties.Settings.Default.Save();
            
            ESP32.CerrarCOnexionESP32();
            Application.Exit();
        }
        #endregion conexion del robot y verificacion de estados

        #region controles de robot

        public void robot(Control btn)
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (Direccion_robot != null)
                {
                    ESP32.enviardatos($"Direccion_robot={Direccion_robot}");
                    btn.BackColor = Color.Lime;
                }
                else
                {
                    ESP32.enviardatos("Direccion_robot=STOP");
                    btn.BackColor = Color.Lime;
                }
            }
            else
            {
                //MessageBox.Show("conexion no establecida");
                btn.BackColor = Color.Red;
            }
        }

        public void R_forward(string dato)
        {
            Direccion_robot = dato;
            robot(btn_robot_avanzar);
        }
        public void R_back(string dato)
        {
            Direccion_robot = dato;
            robot(btn_robot_retroceder);
        }
        public void R_right(string dato)
        {
            Direccion_robot = dato;
            robot(btn_robot_derecha);
        }
        public void R_left(string dato)
        {
            Direccion_robot = dato;
            robot(btn_robot_izquierda);
        }

        private void btn_robot_avanzar_MouseDown(object sender, MouseEventArgs e)
        {
            R_forward("R_Forward");
        }

        private void btn_robot_avanzar_MouseUp(object sender, MouseEventArgs e)
        {
            R_forward(null);
            btn_robot_avanzar.BackColor = Color.Teal;
        }

        private void btn_robot_izquierda_MouseDown(object sender, MouseEventArgs e)
        {
            R_left("R_Left");
        }

        private void btn_robot_izquierda_MouseUp(object sender, MouseEventArgs e)
        {
            R_left(null);
            btn_robot_izquierda.BackColor = Color.Teal;
        }

        private void btn_robot_retroceder_MouseDown(object sender, MouseEventArgs e)
        {
            R_back("R_Back");
        }

        private void btn_robot_retroceder_MouseUp(object sender, MouseEventArgs e)
        {
            R_back(null);
            btn_robot_retroceder.BackColor = Color.Teal;
        }

        private void btn_robot_derecha_MouseDown(object sender, MouseEventArgs e)
        {
            R_right("R_Right");
        }

        private void btn_robot_derecha_MouseUp(object sender, MouseEventArgs e)
        {
            R_right(null);
            btn_robot_derecha.BackColor = Color.Teal;
        }
        #endregion controles de robot

        #region controles de riego manual
        public void torreta(Control btn)
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (Direccion_torreta != null)
                {
                    ESP32.enviardatos($"Direccion_torreta={Direccion_torreta}");
                    //btn.BackColor = Color.FromArgb(25,25,25);
                    btn.BackColor = Color.Lime;
                }
                else
                {
                    ESP32.enviardatos("Direccion_torreta=STOP");
                    btn.BackColor = Color.Lime;
                }
            }
            else
            {
                //MessageBox.Show("conexion no establecida");
                btn.BackColor = Color.Red;
            }
        }

        public void T_up(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta(btn_riego_manual_arriba);
        }
        public void T_down(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta(button2btn_riego_manual_abajo);
        }
        public void T_left(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta(btn_riego_manual_izquierda);
        }
        public void T_right(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta(btn_riego_manual_derecha);
        }
        public void T_reset(string t_dato)
        {
            Direccion_torreta = t_dato;
            torreta(btn_restablecer_posicion_torreta);
        }


        private void btn_riego_manual_arriba_MouseDown(object sender, MouseEventArgs e)
        {
            T_up("T_up");
        }

        private void btn_riego_manual_arriba_MouseUp(object sender, MouseEventArgs e)
        {
            T_up(null);
            btn_riego_manual_arriba.BackColor = Color.Teal;
        }

        private void btn_riego_manual_izquierda_MouseDown(object sender, MouseEventArgs e)
        {
            T_left("T_left");
        }

        private void btn_riego_manual_izquierda_MouseUp(object sender, MouseEventArgs e)
        {
            T_left(null);
            btn_riego_manual_izquierda.BackColor = Color.Teal;
        }

        private void button2btn_riego_manual_abajo_MouseDown(object sender, MouseEventArgs e)
        {
            T_down("T_down");
        }

        private void button2btn_riego_manual_abajo_MouseUp(object sender, MouseEventArgs e)
        {
            T_down(null);
            button2btn_riego_manual_abajo.BackColor = Color.Teal;
        }

        private void btn_riego_manual_derecha_MouseDown(object sender, MouseEventArgs e)
        {
            T_right("T_right");
        }

        private void btn_riego_manual_derecha_MouseUp(object sender, MouseEventArgs e)
        {
            T_right(null);
            btn_riego_manual_derecha.BackColor = Color.Teal;
        }
        private void btn_restablecer_posicion_torreta_Click(object sender, EventArgs e)
        {
            T_reset("T_reset");
        }
        #endregion controles de riego manual

        #region intermitentes
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
                //MessageBox.Show("conexion no establecida");
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
                btn_intermitente_izquierdo.Image = Properties.Resources.intermitente_izquierda_apagado;
                btn_intermitente_izquierdo.FlatAppearance.BorderColor = Color.Red;
                Properties.Settings.Default.btn_i_izquierdo = false;
                Properties.Settings.Default.Save();
                estado_de_intermitentes = false;
            }
            else
            {
                Luces_intermitentes = "I_left";
                //btn_intermitente_izquierdo.BackColor = Color.Lime;
                btn_intermitente_izquierdo.Image = Properties.Resources.intermitente_izquierda_encendido;
                btn_intermitente_izquierdo.FlatAppearance.BorderColor = Color.Lime;
                btn_intermitente_derecho.Image = Properties.Resources.intermitente_derecha_apagado;
                btn_intermitente_derecho.FlatAppearance.BorderColor = Color.Red;
                Properties.Settings.Default.btn_i_izquierdo = true;
                Properties.Settings.Default.btn_i_derecho = false;
                Properties.Settings.Default.Save();
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
                btn_intermitente_advertencia.Image = Properties.Resources.advertencia_apagado;
                btn_intermitente_advertencia.FlatAppearance.BorderColor = Color.Red;
                Properties.Settings.Default.btn_advertencia = false;
                Properties.Settings.Default.Save();
                estado_de_intermitentes = false;
            }
            else
            {
                Luces_intermitentes = "I_advertencia";
                //btn_intermitente_advertencia.BackColor = Color.Lime;
                btn_intermitente_advertencia.Image = Properties.Resources.advertencia_encendido;
                btn_intermitente_advertencia.FlatAppearance.BorderColor = Color.Lime;

                btn_intermitente_derecho.Image = Properties.Resources.intermitente_derecha_apagado;
                btn_intermitente_derecho.FlatAppearance.BorderColor = Color.Red;

                btn_intermitente_izquierdo.Image = Properties.Resources.intermitente_izquierda_apagado;
                btn_intermitente_izquierdo.FlatAppearance.BorderColor = Color.Red;

                Properties.Settings.Default.btn_advertencia = true;
                Properties.Settings.Default.btn_i_izquierdo = false;
                Properties.Settings.Default.btn_i_derecho = false;
                Properties.Settings.Default.Save();
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
                btn_intermitente_derecho.Image = Properties.Resources.intermitente_derecha_apagado;
                btn_intermitente_derecho.FlatAppearance.BorderColor = Color.Red;
                Properties.Settings.Default.btn_i_derecho = false;
                Properties.Settings.Default.Save();
                estado_de_intermitentes = false;
            }
            else
            {
                Luces_intermitentes = "I_right";
                //btn_intermitente_derecho.BackColor = Color.Lime;
                btn_intermitente_derecho.Image = Properties.Resources.intermitente_derecha_encendido;
                btn_intermitente_derecho.FlatAppearance.BorderColor = Color.Lime;
                btn_intermitente_izquierdo.Image = Properties.Resources.intermitente_izquierda_apagado;
                btn_intermitente_izquierdo.FlatAppearance.BorderColor = Color.Red;
                Properties.Settings.Default.btn_i_derecho = true;
                Properties.Settings.Default.btn_i_izquierdo = false;
                Properties.Settings.Default.Save();
                estado_de_intermitentes = true;
            }

            intermitentes();
        }
        private void btn_intermitente_derecho_Click(object sender, EventArgs e)
        {
            intermitente_derecho();
        }
        #endregion intermitentes

        #region luces frontales
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
                //MessageBox.Show("conexion no establecida");
            }
        }
        private bool luzApagada = true;
        public void Luces_Frontales_Tanque()
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (luzApagada)
                {
                    btn_luz.Image = Properties.Resources.luz_encendida;
                    btn_luz.FlatAppearance.BorderColor = Color.Lime;
                    Properties.Settings.Default.btn_luces = true;
                    Properties.Settings.Default.Save();
                    luzApagada = false;
                    Luces_frontales = "LF_ON";
                    luces();
                }
                else
                {
                    btn_luz.Image = Properties.Resources.luz_apagada;
                    btn_luz.FlatAppearance.BorderColor = Color.Red;
                    Properties.Settings.Default.btn_luces = false;
                    Properties.Settings.Default.Save();
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
        #endregion luces frontales

        #region configuracion de teclas
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
                ESP32.CerrarCOnexionESP32();
                this.Visible = false;
                new nav_controller().Visible = true;
            }
            else if (e.KeyCode.ToString() == forwardKey && !w_KeyPressed)
            {
                w_KeyPressed = true;
                R_forward("R_Forward");
            }
            else if (e.KeyCode.ToString() == backKey && !s_KeyPressed)
            {
                s_KeyPressed = true;
                R_back("R_Back");
            }
            else if (e.KeyCode.ToString() == leftKey && !a_KeyPressed)
            {
                a_KeyPressed = true;
                R_left("R_Left");
            }
            else if (e.KeyCode.ToString() == rightKey && !d_KeyPressed)
            {
                d_KeyPressed = true;
                R_right("R_Right");
            }
            else if (e.KeyCode.ToString() == upKey && !i_KeyPressed)
            {
                i_KeyPressed = true;
                T_up("T_up");
                o_KeyPressed = false;
                btn_restablecer_posicion_torreta.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == downKey && !k_KeyPressed)
            {
                k_KeyPressed = true;
                T_down("T_down");
                o_KeyPressed = false;
                btn_restablecer_posicion_torreta.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == rightTorretaKey && !l_KeyPressed)
            {
                l_KeyPressed = true;
                T_right("T_right");
                o_KeyPressed = false;
                btn_restablecer_posicion_torreta.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == leftTorretaKey && !j_KeyPressed)
            {
                j_KeyPressed = true;
                T_left("T_left");
                o_KeyPressed = false;
                btn_restablecer_posicion_torreta.BackColor = Color.Teal;
            }
            else if (e.KeyCode.ToString() == resetTorretaKey && !o_KeyPressed)
            {
                o_KeyPressed = true;
                T_reset("T_reset");
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
                ESP32.conexion(button1, lbl_conexion_remota, camara);
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
        #endregion configuracion de teclas

        #region sensor de humedad
        private bool SensorHumedadApagado = true;
        public void humedad()
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (estado_humedad != null)
                {
                    ESP32.enviardatos($"Estado_humedad={estado_humedad}");
                }
                else
                {
                    ESP32.enviardatos("Estado_humedad=OFF");
                }
            }
            else
            {
                //MessageBox.Show("conexion no establecida");
            }
        }
        public void Sensor_Humedad()
        {
            if (ESP32.conexion_esp32 != true)
            {
                if (SensorHumedadApagado)
                {
                    //btn_Humedad.Image = Properties.Resources.luz_apagada;
                    //btn_Humedad.BackColor = Color.Lime;
                    btn_Humedad.FlatAppearance.BorderColor = Color.Lime;
                    btn_Humedad.Image = Properties.Resources.Humedad_activado;
                    Properties.Settings.Default.btn_activar_s_humedad = true;
                    Properties.Settings.Default.Save();
                    SensorHumedadApagado = false;
                    estado_humedad = "H_ON";
                    humedad();
                }
                else
                {
                    //btn_Humedad.Image = Properties.Resources.luz_encendida;
                    //btn_Humedad.BackColor = Color.Teal;
                    btn_Humedad.FlatAppearance.BorderColor = Color.Red;
                    btn_Humedad.Image = Properties.Resources.Humedad_inactivo;
                    Properties.Settings.Default.btn_activar_s_humedad = false;
                    Properties.Settings.Default.Save();
                    SensorHumedadApagado = true;
                    estado_humedad = "H_OFF";
                    humedad();
                }
            }

            else
            {
                MessageBox.Show("conexion no establecida");
            }
        }
        private void btn_Humedad_Click(object sender, EventArgs e)
        {
            Sensor_Humedad();
        }
        #endregion sensor de humedad

        
    }
}
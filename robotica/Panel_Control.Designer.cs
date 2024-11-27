namespace robotica
{
    partial class Panel_Control
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Control));
            this.lbl_conexion_remota = new System.Windows.Forms.Label();
            this.btn_configuracion = new System.Windows.Forms.Button();
            this.btn_cerrar_programa = new System.Windows.Forms.Button();
            this.btn_Humedad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_restablecer_posicion_torreta = new System.Windows.Forms.Button();
            this.btn_intermitente_derecho = new System.Windows.Forms.Button();
            this.btn_intermitente_advertencia = new System.Windows.Forms.Button();
            this.btn_intermitente_izquierdo = new System.Windows.Forms.Button();
            this.btn_luz = new System.Windows.Forms.Button();
            this.button2btn_riego_manual_abajo = new System.Windows.Forms.Button();
            this.btn_riego_manual_derecha = new System.Windows.Forms.Button();
            this.btn_riego_manual_izquierda = new System.Windows.Forms.Button();
            this.btn_riego_manual_arriba = new System.Windows.Forms.Button();
            this.btn_robot_retroceder = new System.Windows.Forms.Button();
            this.btn_robot_derecha = new System.Windows.Forms.Button();
            this.btn_robot_izquierda = new System.Windows.Forms.Button();
            this.btn_robot_avanzar = new System.Windows.Forms.Button();
            this.camara = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.camara)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_conexion_remota
            // 
            this.lbl_conexion_remota.AutoSize = true;
            this.lbl_conexion_remota.BackColor = System.Drawing.Color.Transparent;
            this.lbl_conexion_remota.ForeColor = System.Drawing.Color.White;
            this.lbl_conexion_remota.Location = new System.Drawing.Point(665, 177);
            this.lbl_conexion_remota.Name = "lbl_conexion_remota";
            this.lbl_conexion_remota.Size = new System.Drawing.Size(225, 20);
            this.lbl_conexion_remota.TabIndex = 29;
            this.lbl_conexion_remota.Text = "Desconectado con el robot";
            // 
            // btn_configuracion
            // 
            this.btn_configuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_configuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_configuracion.FlatAppearance.BorderSize = 0;
            this.btn_configuracion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracion.Location = new System.Drawing.Point(666, 200);
            this.btn_configuracion.Name = "btn_configuracion";
            this.btn_configuracion.Size = new System.Drawing.Size(217, 50);
            this.btn_configuracion.TabIndex = 32;
            this.btn_configuracion.Text = "Ver confoguracion";
            this.btn_configuracion.UseVisualStyleBackColor = false;
            this.btn_configuracion.Click += new System.EventHandler(this.btn_configuracion_Click);
            // 
            // btn_cerrar_programa
            // 
            this.btn_cerrar_programa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_cerrar_programa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_programa.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_programa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_cerrar_programa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_programa.Location = new System.Drawing.Point(666, 124);
            this.btn_cerrar_programa.Name = "btn_cerrar_programa";
            this.btn_cerrar_programa.Size = new System.Drawing.Size(217, 50);
            this.btn_cerrar_programa.TabIndex = 33;
            this.btn_cerrar_programa.Text = "Cerrar";
            this.btn_cerrar_programa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar_programa.UseVisualStyleBackColor = false;
            this.btn_cerrar_programa.Click += new System.EventHandler(this.btn_cerrar_programa_Click);
            // 
            // btn_Humedad
            // 
            this.btn_Humedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_Humedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Humedad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Humedad.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Humedad.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_Humedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Humedad.Image = global::robotica.Properties.Resources.Humedad_inactivo;
            this.btn_Humedad.Location = new System.Drawing.Point(665, 68);
            this.btn_Humedad.Name = "btn_Humedad";
            this.btn_Humedad.Size = new System.Drawing.Size(50, 50);
            this.btn_Humedad.TabIndex = 34;
            this.btn_Humedad.UseVisualStyleBackColor = false;
            this.btn_Humedad.Click += new System.EventHandler(this.btn_Humedad_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::robotica.Properties.Resources.Desconectar_Robot;
            this.button1.Location = new System.Drawing.Point(721, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 50);
            this.button1.TabIndex = 30;
            this.button1.Text = " Desconectado";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_restablecer_posicion_torreta
            // 
            this.btn_restablecer_posicion_torreta.BackColor = System.Drawing.Color.Teal;
            this.btn_restablecer_posicion_torreta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restablecer_posicion_torreta.FlatAppearance.BorderSize = 0;
            this.btn_restablecer_posicion_torreta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_restablecer_posicion_torreta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restablecer_posicion_torreta.Image = ((System.Drawing.Image)(resources.GetObject("btn_restablecer_posicion_torreta.Image")));
            this.btn_restablecer_posicion_torreta.Location = new System.Drawing.Point(469, 560);
            this.btn_restablecer_posicion_torreta.Name = "btn_restablecer_posicion_torreta";
            this.btn_restablecer_posicion_torreta.Size = new System.Drawing.Size(50, 50);
            this.btn_restablecer_posicion_torreta.TabIndex = 28;
            this.btn_restablecer_posicion_torreta.UseVisualStyleBackColor = false;
            this.btn_restablecer_posicion_torreta.Click += new System.EventHandler(this.btn_restablecer_posicion_torreta_Click);
            // 
            // btn_intermitente_derecho
            // 
            this.btn_intermitente_derecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_intermitente_derecho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_intermitente_derecho.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_intermitente_derecho.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_intermitente_derecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_intermitente_derecho.Image = global::robotica.Properties.Resources.intermitente_derecha_apagado;
            this.btn_intermitente_derecho.Location = new System.Drawing.Point(833, 12);
            this.btn_intermitente_derecho.Name = "btn_intermitente_derecho";
            this.btn_intermitente_derecho.Size = new System.Drawing.Size(50, 50);
            this.btn_intermitente_derecho.TabIndex = 22;
            this.btn_intermitente_derecho.UseVisualStyleBackColor = false;
            this.btn_intermitente_derecho.Click += new System.EventHandler(this.btn_intermitente_derecho_Click);
            // 
            // btn_intermitente_advertencia
            // 
            this.btn_intermitente_advertencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_intermitente_advertencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_intermitente_advertencia.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_intermitente_advertencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_intermitente_advertencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_intermitente_advertencia.Image = global::robotica.Properties.Resources.advertencia_apagado;
            this.btn_intermitente_advertencia.Location = new System.Drawing.Point(777, 12);
            this.btn_intermitente_advertencia.Name = "btn_intermitente_advertencia";
            this.btn_intermitente_advertencia.Size = new System.Drawing.Size(50, 50);
            this.btn_intermitente_advertencia.TabIndex = 21;
            this.btn_intermitente_advertencia.UseVisualStyleBackColor = false;
            this.btn_intermitente_advertencia.Click += new System.EventHandler(this.btn_intermitente_advertencia_Click);
            // 
            // btn_intermitente_izquierdo
            // 
            this.btn_intermitente_izquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_intermitente_izquierdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_intermitente_izquierdo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_intermitente_izquierdo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_intermitente_izquierdo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_intermitente_izquierdo.Image = global::robotica.Properties.Resources.intermitente_izquierda_apagado;
            this.btn_intermitente_izquierdo.Location = new System.Drawing.Point(721, 12);
            this.btn_intermitente_izquierdo.Name = "btn_intermitente_izquierdo";
            this.btn_intermitente_izquierdo.Size = new System.Drawing.Size(50, 50);
            this.btn_intermitente_izquierdo.TabIndex = 19;
            this.btn_intermitente_izquierdo.UseVisualStyleBackColor = false;
            this.btn_intermitente_izquierdo.Click += new System.EventHandler(this.btn_intermitente_izquierdo_Click);
            // 
            // btn_luz
            // 
            this.btn_luz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btn_luz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luz.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_luz.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_luz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luz.Image = ((System.Drawing.Image)(resources.GetObject("btn_luz.Image")));
            this.btn_luz.Location = new System.Drawing.Point(665, 12);
            this.btn_luz.Name = "btn_luz";
            this.btn_luz.Size = new System.Drawing.Size(50, 50);
            this.btn_luz.TabIndex = 18;
            this.btn_luz.UseVisualStyleBackColor = false;
            this.btn_luz.Click += new System.EventHandler(this.btn_luz_Click);
            // 
            // button2btn_riego_manual_abajo
            // 
            this.button2btn_riego_manual_abajo.BackColor = System.Drawing.Color.Teal;
            this.button2btn_riego_manual_abajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2btn_riego_manual_abajo.FlatAppearance.BorderSize = 0;
            this.button2btn_riego_manual_abajo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button2btn_riego_manual_abajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2btn_riego_manual_abajo.Image = global::robotica.Properties.Resources.Torreta_abajo;
            this.button2btn_riego_manual_abajo.Location = new System.Drawing.Point(469, 616);
            this.button2btn_riego_manual_abajo.Name = "button2btn_riego_manual_abajo";
            this.button2btn_riego_manual_abajo.Size = new System.Drawing.Size(50, 50);
            this.button2btn_riego_manual_abajo.TabIndex = 14;
            this.button2btn_riego_manual_abajo.UseVisualStyleBackColor = false;
            this.button2btn_riego_manual_abajo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2btn_riego_manual_abajo_MouseDown);
            this.button2btn_riego_manual_abajo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2btn_riego_manual_abajo_MouseUp);
            // 
            // btn_riego_manual_derecha
            // 
            this.btn_riego_manual_derecha.BackColor = System.Drawing.Color.Teal;
            this.btn_riego_manual_derecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_riego_manual_derecha.FlatAppearance.BorderSize = 0;
            this.btn_riego_manual_derecha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_riego_manual_derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_riego_manual_derecha.Image = global::robotica.Properties.Resources.Torreta_derecho;
            this.btn_riego_manual_derecha.Location = new System.Drawing.Point(525, 560);
            this.btn_riego_manual_derecha.Name = "btn_riego_manual_derecha";
            this.btn_riego_manual_derecha.Size = new System.Drawing.Size(50, 50);
            this.btn_riego_manual_derecha.TabIndex = 13;
            this.btn_riego_manual_derecha.UseVisualStyleBackColor = false;
            this.btn_riego_manual_derecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_riego_manual_derecha_MouseDown);
            this.btn_riego_manual_derecha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_riego_manual_derecha_MouseUp);
            // 
            // btn_riego_manual_izquierda
            // 
            this.btn_riego_manual_izquierda.BackColor = System.Drawing.Color.Teal;
            this.btn_riego_manual_izquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_riego_manual_izquierda.FlatAppearance.BorderSize = 0;
            this.btn_riego_manual_izquierda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_riego_manual_izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_riego_manual_izquierda.Image = global::robotica.Properties.Resources.Torreta_izquierdo;
            this.btn_riego_manual_izquierda.Location = new System.Drawing.Point(413, 560);
            this.btn_riego_manual_izquierda.Name = "btn_riego_manual_izquierda";
            this.btn_riego_manual_izquierda.Size = new System.Drawing.Size(50, 50);
            this.btn_riego_manual_izquierda.TabIndex = 12;
            this.btn_riego_manual_izquierda.UseVisualStyleBackColor = false;
            this.btn_riego_manual_izquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_riego_manual_izquierda_MouseDown);
            this.btn_riego_manual_izquierda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_riego_manual_izquierda_MouseUp);
            // 
            // btn_riego_manual_arriba
            // 
            this.btn_riego_manual_arriba.BackColor = System.Drawing.Color.Teal;
            this.btn_riego_manual_arriba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_riego_manual_arriba.FlatAppearance.BorderSize = 0;
            this.btn_riego_manual_arriba.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_riego_manual_arriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_riego_manual_arriba.Image = global::robotica.Properties.Resources.Torreta_arriba;
            this.btn_riego_manual_arriba.Location = new System.Drawing.Point(469, 504);
            this.btn_riego_manual_arriba.Name = "btn_riego_manual_arriba";
            this.btn_riego_manual_arriba.Size = new System.Drawing.Size(50, 50);
            this.btn_riego_manual_arriba.TabIndex = 11;
            this.btn_riego_manual_arriba.UseVisualStyleBackColor = false;
            this.btn_riego_manual_arriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_riego_manual_arriba_MouseDown);
            this.btn_riego_manual_arriba.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_riego_manual_arriba_MouseUp);
            // 
            // btn_robot_retroceder
            // 
            this.btn_robot_retroceder.BackColor = System.Drawing.Color.Teal;
            this.btn_robot_retroceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_robot_retroceder.FlatAppearance.BorderSize = 0;
            this.btn_robot_retroceder.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_robot_retroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_robot_retroceder.Image = global::robotica.Properties.Resources.abajo;
            this.btn_robot_retroceder.Location = new System.Drawing.Point(68, 616);
            this.btn_robot_retroceder.Name = "btn_robot_retroceder";
            this.btn_robot_retroceder.Size = new System.Drawing.Size(50, 50);
            this.btn_robot_retroceder.TabIndex = 10;
            this.btn_robot_retroceder.UseVisualStyleBackColor = false;
            this.btn_robot_retroceder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_robot_retroceder_MouseDown);
            this.btn_robot_retroceder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_robot_retroceder_MouseUp);
            // 
            // btn_robot_derecha
            // 
            this.btn_robot_derecha.BackColor = System.Drawing.Color.Teal;
            this.btn_robot_derecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_robot_derecha.FlatAppearance.BorderSize = 0;
            this.btn_robot_derecha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_robot_derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_robot_derecha.Image = global::robotica.Properties.Resources.derecho;
            this.btn_robot_derecha.Location = new System.Drawing.Point(124, 560);
            this.btn_robot_derecha.Name = "btn_robot_derecha";
            this.btn_robot_derecha.Size = new System.Drawing.Size(50, 50);
            this.btn_robot_derecha.TabIndex = 7;
            this.btn_robot_derecha.UseVisualStyleBackColor = false;
            this.btn_robot_derecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_robot_derecha_MouseDown);
            this.btn_robot_derecha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_robot_derecha_MouseUp);
            // 
            // btn_robot_izquierda
            // 
            this.btn_robot_izquierda.BackColor = System.Drawing.Color.Teal;
            this.btn_robot_izquierda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_robot_izquierda.FlatAppearance.BorderSize = 0;
            this.btn_robot_izquierda.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_robot_izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_robot_izquierda.Image = global::robotica.Properties.Resources.izquierdo;
            this.btn_robot_izquierda.Location = new System.Drawing.Point(12, 560);
            this.btn_robot_izquierda.Name = "btn_robot_izquierda";
            this.btn_robot_izquierda.Size = new System.Drawing.Size(50, 50);
            this.btn_robot_izquierda.TabIndex = 4;
            this.btn_robot_izquierda.UseVisualStyleBackColor = false;
            this.btn_robot_izquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_robot_izquierda_MouseDown);
            this.btn_robot_izquierda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_robot_izquierda_MouseUp);
            // 
            // btn_robot_avanzar
            // 
            this.btn_robot_avanzar.BackColor = System.Drawing.Color.Teal;
            this.btn_robot_avanzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_robot_avanzar.FlatAppearance.BorderSize = 0;
            this.btn_robot_avanzar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_robot_avanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_robot_avanzar.Image = global::robotica.Properties.Resources.arriba;
            this.btn_robot_avanzar.Location = new System.Drawing.Point(68, 504);
            this.btn_robot_avanzar.Name = "btn_robot_avanzar";
            this.btn_robot_avanzar.Size = new System.Drawing.Size(50, 50);
            this.btn_robot_avanzar.TabIndex = 1;
            this.btn_robot_avanzar.UseVisualStyleBackColor = false;
            this.btn_robot_avanzar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_robot_avanzar_MouseDown);
            this.btn_robot_avanzar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_robot_avanzar_MouseUp);
            // 
            // camara
            // 
            this.camara.BackColor = System.Drawing.Color.Transparent;
            this.camara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.camara.ErrorImage = ((System.Drawing.Image)(resources.GetObject("camara.ErrorImage")));
            this.camara.Image = global::robotica.Properties.Resources.logo_convertsystems_con_nombre_sin_fondo_08;
            this.camara.Location = new System.Drawing.Point(12, 12);
            this.camara.Name = "camara";
            this.camara.Size = new System.Drawing.Size(640, 480);
            this.camara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.camara.TabIndex = 0;
            this.camara.TabStop = false;
            // 
            // Panel_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(895, 678);
            this.Controls.Add(this.btn_Humedad);
            this.Controls.Add(this.btn_cerrar_programa);
            this.Controls.Add(this.btn_configuracion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_conexion_remota);
            this.Controls.Add(this.btn_restablecer_posicion_torreta);
            this.Controls.Add(this.btn_intermitente_derecho);
            this.Controls.Add(this.btn_intermitente_advertencia);
            this.Controls.Add(this.btn_intermitente_izquierdo);
            this.Controls.Add(this.btn_luz);
            this.Controls.Add(this.button2btn_riego_manual_abajo);
            this.Controls.Add(this.btn_riego_manual_derecha);
            this.Controls.Add(this.btn_riego_manual_izquierda);
            this.Controls.Add(this.btn_riego_manual_arriba);
            this.Controls.Add(this.btn_robot_retroceder);
            this.Controls.Add(this.btn_robot_derecha);
            this.Controls.Add(this.btn_robot_izquierda);
            this.Controls.Add(this.btn_robot_avanzar);
            this.Controls.Add(this.camara);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Panel_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Panel_Control_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.camara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox camara;
        private System.Windows.Forms.Button btn_robot_avanzar;
        private System.Windows.Forms.Button btn_robot_izquierda;
        private System.Windows.Forms.Button btn_robot_derecha;
        private System.Windows.Forms.Button btn_robot_retroceder;
        private System.Windows.Forms.Button button2btn_riego_manual_abajo;
        private System.Windows.Forms.Button btn_riego_manual_derecha;
        private System.Windows.Forms.Button btn_riego_manual_izquierda;
        private System.Windows.Forms.Button btn_riego_manual_arriba;
        private System.Windows.Forms.Button btn_luz;
        private System.Windows.Forms.Button btn_intermitente_izquierdo;
        private System.Windows.Forms.Button btn_intermitente_advertencia;
        private System.Windows.Forms.Button btn_intermitente_derecho;
        private System.Windows.Forms.Button btn_restablecer_posicion_torreta;
        private System.Windows.Forms.Label lbl_conexion_remota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_configuracion;
        private System.Windows.Forms.Button btn_cerrar_programa;
        private System.Windows.Forms.Button btn_Humedad;
    }
}


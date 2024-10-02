namespace robotica
{
    partial class nav_controller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_confuguracion_teclas = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.pnl_vistas = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "ConvertSystems Dev Corporation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::robotica.Properties.Resources.logo_convertsystems_sin_fondo_05;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 60);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_confuguracion_teclas);
            this.panel2.Controls.Add(this.btn_volver);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 515);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 72);
            this.panel2.TabIndex = 1;
            // 
            // btn_confuguracion_teclas
            // 
            this.btn_confuguracion_teclas.AutoSize = true;
            this.btn_confuguracion_teclas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confuguracion_teclas.BackColor = System.Drawing.Color.White;
            this.btn_confuguracion_teclas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_confuguracion_teclas.FlatAppearance.BorderSize = 0;
            this.btn_confuguracion_teclas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_confuguracion_teclas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_confuguracion_teclas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_confuguracion_teclas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confuguracion_teclas.Location = new System.Drawing.Point(70, 0);
            this.btn_confuguracion_teclas.Name = "btn_confuguracion_teclas";
            this.btn_confuguracion_teclas.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_confuguracion_teclas.Size = new System.Drawing.Size(85, 72);
            this.btn_confuguracion_teclas.TabIndex = 32;
            this.btn_confuguracion_teclas.Text = "Teclas";
            this.btn_confuguracion_teclas.UseVisualStyleBackColor = false;
            this.btn_confuguracion_teclas.Click += new System.EventHandler(this.btn_confuguracion_teclas_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.AutoSize = true;
            this.btn_volver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_volver.BackColor = System.Drawing.Color.White;
            this.btn_volver.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btn_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Location = new System.Drawing.Point(0, 0);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_volver.Size = new System.Drawing.Size(70, 72);
            this.btn_volver.TabIndex = 31;
            this.btn_volver.Text = "Salir";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // pnl_vistas
            // 
            this.pnl_vistas.BackgroundImage = global::robotica.Properties.Resources.logo_convertsystems_sin_fondo_05;
            this.pnl_vistas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_vistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_vistas.Location = new System.Drawing.Point(0, 60);
            this.pnl_vistas.Name = "pnl_vistas";
            this.pnl_vistas.Size = new System.Drawing.Size(993, 455);
            this.pnl_vistas.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(155, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(224, 72);
            this.button1.TabIndex = 33;
            this.button1.Text = "Configuracion De Sistema";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // nav_controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 587);
            this.Controls.Add(this.pnl_vistas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "nav_controller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nav_controller";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_vistas;
        private System.Windows.Forms.Button btn_confuguracion_teclas;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
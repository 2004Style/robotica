namespace robotica
{
    partial class ConfiguracionDeControles
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
            this.configuracion_teclas = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tecla = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.configuracion_teclas)).BeginInit();
            this.SuspendLayout();
            // 
            // configuracion_teclas
            // 
            this.configuracion_teclas.AllowUserToAddRows = false;
            this.configuracion_teclas.AllowUserToDeleteRows = false;
            this.configuracion_teclas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.configuracion_teclas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.configuracion_teclas.BackgroundColor = System.Drawing.Color.White;
            this.configuracion_teclas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configuracion_teclas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.configuracion_teclas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Tecla});
            this.configuracion_teclas.Location = new System.Drawing.Point(12, 12);
            this.configuracion_teclas.Name = "configuracion_teclas";
            this.configuracion_teclas.ReadOnly = true;
            this.configuracion_teclas.RowHeadersVisible = false;
            this.configuracion_teclas.Size = new System.Drawing.Size(969, 431);
            this.configuracion_teclas.TabIndex = 16;
            this.configuracion_teclas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Tecla
            // 
            this.Tecla.FillWeight = 30F;
            this.Tecla.HeaderText = "Tecla";
            this.Tecla.Name = "Tecla";
            this.Tecla.ReadOnly = true;
            this.Tecla.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tecla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ConfiguracionDeControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 455);
            this.Controls.Add(this.configuracion_teclas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfiguracionDeControles";
            this.Text = "ConfiguracionDeControles";
            ((System.ComponentModel.ISupportInitialize)(this.configuracion_teclas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView configuracion_teclas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Tecla;
    }
}
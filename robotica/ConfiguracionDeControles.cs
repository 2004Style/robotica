using System;
using System.Windows.Forms;

namespace robotica
{
    public partial class ConfiguracionDeControles : Form
    {
        private int filaSeleccionada = -1;

        public ConfiguracionDeControles()
        {
            InitializeComponent();
            config_teclas();
        }

        private void config_teclas()
        {
            configuracion_teclas.Rows.Add("Encender/Apagar Luces", Properties.Settings.Default.Luces);
            configuracion_teclas.Rows.Add("Encender/Apagar Intermitente Izquierdo", Properties.Settings.Default.Intermitente_I);
            configuracion_teclas.Rows.Add("Encender/Apagar Intermitente Derecho", Properties.Settings.Default.Intermitente_D);
            configuracion_teclas.Rows.Add("Encender/Apagar Luces De Advertencia", Properties.Settings.Default.Intermitentes_A);
            configuracion_teclas.Rows.Add("Conducir Adelante", Properties.Settings.Default.R_Folwar);
            configuracion_teclas.Rows.Add("Conducir Atrás", Properties.Settings.Default.R_Back);
            configuracion_teclas.Rows.Add("Conducir Izquierda", Properties.Settings.Default.R_Left);
            configuracion_teclas.Rows.Add("Conducir Derecha", Properties.Settings.Default.R_Right);
            configuracion_teclas.Rows.Add("Torreta Arriba", Properties.Settings.Default.T_up);
            configuracion_teclas.Rows.Add("Torreta Abajo", Properties.Settings.Default.T_Down);
            configuracion_teclas.Rows.Add("Torreta Izquierda", Properties.Settings.Default.T_Left);
            configuracion_teclas.Rows.Add("Torreta Derecha", Properties.Settings.Default.T_Right);
            configuracion_teclas.Rows.Add("Restablecer Posición De La Torreta", Properties.Settings.Default.T_Reset);
            configuracion_teclas.Rows.Add("Conectar/Desconectar Robot", Properties.Settings.Default.Conectar);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == configuracion_teclas.Columns["Tecla"].Index && e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                this.KeyPreview = true;
                this.KeyDown += KeyDownHandler;
            }
        }

        private void KeyDownHandler(object sender, KeyEventArgs e)
        {
            if (filaSeleccionada >= 0)
            {
                string combinacion = "";

                if (e.Control)
                {
                    combinacion += "Ctrl + ";
                }
                if (e.Shift)
                {
                    combinacion += "Shift + ";
                }
                if (e.Alt)
                {
                    combinacion += "Alt + ";
                }

                combinacion += e.KeyCode.ToString();

                configuracion_teclas.Rows[filaSeleccionada].Cells["Tecla"].Value = combinacion;

                switch (filaSeleccionada)
                {
                    case 0: Properties.Settings.Default.Luces = combinacion; break;
                    case 1: Properties.Settings.Default.Intermitente_I = combinacion; break;
                    case 2: Properties.Settings.Default.Intermitente_D = combinacion; break;
                    case 3: Properties.Settings.Default.Intermitentes_A = combinacion; break;
                    case 4: Properties.Settings.Default.R_Folwar = combinacion; break;
                    case 5: Properties.Settings.Default.R_Back = combinacion; break;
                    case 6: Properties.Settings.Default.R_Left = combinacion; break;
                    case 7: Properties.Settings.Default.R_Right = combinacion; break;
                    case 8: Properties.Settings.Default.T_up = combinacion; break;
                    case 9: Properties.Settings.Default.T_Down = combinacion; break;
                    case 10: Properties.Settings.Default.T_Left = combinacion; break;
                    case 11: Properties.Settings.Default.T_Right = combinacion; break;
                    case 12: Properties.Settings.Default.T_Reset = combinacion; break;
                    case 13: Properties.Settings.Default.Conectar = combinacion; break;
                }

                Properties.Settings.Default.Save();

                this.KeyPreview = false;
                this.KeyDown -= KeyDownHandler;

                filaSeleccionada = -1;
            }
        }

        private void btn_prueba_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Panel_Control().Visible = true;
        }
    }
}

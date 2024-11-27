using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gui_submenus_formularios;
using Sistema_De_Riego;

namespace robotica
{
    public partial class nav_controller : Form
    {
        mostrar_formulario_dentro_de_un_panel mf = new mostrar_formulario_dentro_de_un_panel();
        public nav_controller()
        {
            InitializeComponent();
        }
        private void btn_confuguracion_teclas_Click(object sender, EventArgs e)
        {
            mf.abrirFormularioHijoEnPanel(new ConfiguracionDeControles(), pnl_vistas);
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Panel_Control().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

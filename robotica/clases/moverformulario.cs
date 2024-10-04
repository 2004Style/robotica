using System.Drawing;
using System.Windows.Forms;

namespace robotica.clases
{
    public class moverformulario
    {
        private Form form;
        private Control dragControl;
        private bool isDragging;
        private Point offset;

        public moverformulario(Form form, Control dragControl)
        {
            this.form = form;
            this.dragControl = dragControl;

            dragControl.MouseDown += DragControl_MouseDown;
            dragControl.MouseMove += DragControl_MouseMove;
            dragControl.MouseUp += DragControl_MouseUp;
        }

        private void DragControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = e.Location;
            }
        }

        private void DragControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPos = form.PointToScreen(e.Location);
                form.Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void DragControl_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}

using Lab2.Components;
using System.Windows.Forms;
using static Lab2.OpenGL;

namespace Lab2
{
    public partial class MainForm : Form
    {
        FigureController controller;

        public MainForm()
        {
            InitializeComponent();
            controller = new FigureController();
            renderControl1.setSize(panel1.Width, panel1.Height);
        }

        private void Y_ValueChanged(object sender, System.EventArgs e)
        {
            controller.SetTilesCount((int)numericUpDown2.Value, (int)numericUpDown1.Value);
            renderControl1.Refresh();
        }

        private void X_ValueChanged(object sender, System.EventArgs e)
        {
            controller.SetTilesCount((int)numericUpDown2.Value, (int)numericUpDown1.Value);
            renderControl1.Refresh();
        }

        private void panel1_Resize(object sender, System.EventArgs e)
        {
            renderControl1.setSize(panel1.Width, panel1.Height);
        }

        private void FillMode_Checked(object sender, System.EventArgs e)
        {
            controller.SetDefaultMode();
            renderControl1.Refresh();
        }

        private void LineMode_Checked(object sender, System.EventArgs e)
        {
            controller.SetMode(GL_LINE);
            renderControl1.Refresh();
        }

        private void PointMode_Checked(object sender, System.EventArgs e)
        {
            controller.SetMode(GL_POINT);
            renderControl1.Refresh();
        }
    }
}

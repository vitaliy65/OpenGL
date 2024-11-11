using System.Windows.Forms;
using Task_05.Components;
using static Task_05.OpenGL;


namespace Task_05
{
    public partial class MainForm : Form
    {
        GridView _gridView;

        public MainForm()
        {
            InitializeComponent();
            renderControl1.Width = renderControl1.Parent.Width;
            renderControl1.Height = renderControl1.Parent.Height;

            _gridView = new GridView();
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            _gridView.SetGridSize((int)numericUpDown1.Value);
            renderControl1.Invalidate();
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.fillFigure = !renderControl1.fillFigure;
            renderControl1.Invalidate();
        }
    }
}

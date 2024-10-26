using System.Windows.Forms;


namespace Task_04
{
    public partial class MainForm : Form
    {
        FigureController FigureController;

        public MainForm()
        {
            InitializeComponent();
            FigureController = new FigureController();
            renderControl1.setSize(panel2.Width, panel2.Height);
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            FigureController.SetXmin((double)numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
        {
            FigureController.SetXmax((double)numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, System.EventArgs e)
        {
            FigureController.SetNumPoints((int)numericUpDown3.Value);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            renderControl1.Refresh();
        }

        private void panel2_Resize(object sender, System.EventArgs e)
        {
            renderControl1.setSize(panel2.Width, panel2.Height);
        }
    }
}

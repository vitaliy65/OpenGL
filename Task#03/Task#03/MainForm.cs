using System.Windows.Forms;


namespace Task_03
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            FigureController.SetXmin((double)numericUpDown1.Value);
            FigureController.SetXmax((double)numericUpDown2.Value);
            FigureController.SetNumPoints((int)numericUpDown3.Value);
            FigureController.SetYmax((double)numericUpDown4.Value);
            FigureController.SetYmin((double)numericUpDown5.Value);
            renderControl1.Refresh();
        }

        private void panel2_Resize(object sender, System.EventArgs e) => renderControl1.setSize(panel2.Width, panel2.Height);

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked)
                FigureController.SelectFunction("f2");
            else
                FigureController.SelectFunction("f1");
        }
    }
}

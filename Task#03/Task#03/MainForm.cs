using System.Windows.Forms;
using Task_04.Components;

namespace Task_04
{
    public partial class MainForm : Form
    {
        ViewController viewController;
        Circle circle;
        Elips elips;

        public MainForm()
        {
            InitializeComponent();
            viewController = new ViewController();
            circle = new Circle();
            elips = new Elips();
            renderControl2.setSize(panel2.Width, panel2.Height);
            ViewController._xMin = (int)numericUpDown1.Value;
            ViewController._xMax = (int)numericUpDown2.Value;
            ViewController._yMin = (int)numericUpDown3.Value;
            ViewController._yMax = (int)numericUpDown4.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            ViewController._xMin = (int)numericUpDown1.Value;
            renderControl2.Refresh();
        }

        private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
        {
            ViewController._xMax = (int)numericUpDown2.Value;
            renderControl2.Refresh();
        }

        private void numericUpDown3_ValueChanged(object sender, System.EventArgs e)
        {
            ViewController._yMin = (int)numericUpDown3.Value;
            renderControl2.Refresh();
        }

        private void numericUpDown4_ValueChanged(object sender, System.EventArgs e)
        {
            ViewController._yMax = (int)numericUpDown4.Value;
            renderControl2.Refresh();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string[] point = textBox1.Text.Split(',');
            try
            {
                int x = int.Parse(point[0]);
                int y = int.Parse(point[1]);
                circle.center = new Point(x, y);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ви ввели невірні дані, спробуйте ще раз.");
            }

            point = textBox2.Text.Split(',');
            try
            {
                int x = int.Parse(point[0]);
                int y = int.Parse(point[1]);
                elips.center = new Point(x, y);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ви ввели невірні дані, спробуйте ще раз.");
            }

            circle.radius = (float)numericUpDown5.Value;
            elips.radiusX = (float)numericUpDown6.Value;
            elips.radiusY = (float)numericUpDown7.Value;

            renderControl2.SetFigureToRender(elips.DrawFigure);
            renderControl2.SetFigureToRender(circle.DrawFigure);

            renderControl2.Refresh();
        }

        private void panel2_Resize(object sender, System.EventArgs e)
        {
            renderControl2.setSize(panel2.Width, panel2.Height);
        }
    }
}

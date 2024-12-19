using System.Reflection.Emit;
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
            SetupRenderControl();
            renderControl1.Width = renderControl1.Parent.Width;
            renderControl1.Height = renderControl1.Parent.Height;

            var controlModel = renderControl1._model;
            label1.Text = $"Alpha: {controlModel.AngleAlpha}";
            label2.Text = $"Beta: {controlModel.AngleBeta}";
            label3.Text = $"Gamma: {controlModel.AngleGamma}";

            _gridView = new GridView();
        }

        private void SetupRenderControl()
        {
            KeyDown += KeyPressDown;
        }

        private void KeyPressDown(object sender, KeyEventArgs e)
        {
            var controlModel = renderControl1._model;
            float rotateState = 5f;
            switch (e.KeyCode)
            {
                case Keys.A:
                    controlModel.UpdateAlphaAngle(controlModel.AngleAlpha + rotateState);
                    break;
                case Keys.Z:
                    controlModel.UpdateAlphaAngle(controlModel.AngleAlpha - rotateState);
                    break;
                case Keys.S:
                    controlModel.UpdateSigmaAngle(controlModel.AngleSigma + rotateState);
                    break;
                case Keys.X:
                    controlModel.UpdateSigmaAngle(controlModel.AngleSigma - rotateState);
                    break;
                case Keys.D:
                    controlModel.UpdateGammaAngle(controlModel.AngleGamma + rotateState);
                    break;
                case Keys.C:
                    controlModel.UpdateGammaAngle(controlModel.AngleGamma - rotateState);
                    break;
            }
            label1.Text = $"Alpha: {controlModel.AngleAlpha}";
            label2.Text = $"Sigma: {controlModel.AngleSigma}";
            label3.Text = $"Gamma: {controlModel.AngleGamma}";
            label4.Text = $"C: {controlModel.C}";
            renderControl1.Invalidate();
        }
    }
}

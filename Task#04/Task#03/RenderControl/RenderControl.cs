using System;
using Task_04.Components;
using System.Windows.Forms;

namespace Task_04
{
    public partial class RenderControl : OpenGL
    {
        public delegate void RenderFigureFunction();

        RenderFigureFunction renderFigure;

        ViewController viewController;
        UserLine userLine;

        int _ParentWidth = 0;
        int _ParentHeight = 0;


        public RenderControl()
        {
            InitializeComponent();
            viewController = new ViewController();
            userLine = new UserLine();
        }

        public void setSize(int parentWidth, int parentHeight)
        {
            _ParentWidth = parentWidth;
            _ParentHeight = parentHeight;
        }

        public void SetFigureToRender(RenderFigureFunction f) => renderFigure += f;

        private void RenderControl_Render(object sender, EventArgs e)
        {
            if (ViewController._xMin != 0 && ViewController._xMax != 0 && ViewController._yMin != 0 && ViewController._yMax != 0)
            {
                viewController.SetView(_ParentWidth, _ParentHeight);
                if (renderFigure != null) renderFigure.Invoke();
                userLine.DrawLine();
            }
        }

        private void RenderControl_MouseClick(object sender, MouseEventArgs e)
        {
            float xOpenGL = (float) (e.X / (float)_ParentWidth  * (ViewController._xMax - ViewController._xMin) + ViewController._xMin);
            float yOpenGL = (float) ((_ParentHeight - e.Y) / (float)_ParentWidth * (ViewController._yMax - ViewController._yMin) + ViewController._yMin);

            if (e.Button == MouseButtons.Left) userLine.SetLMBpoint(xOpenGL, yOpenGL);

            if (e.Button == MouseButtons.Right)
            {
                userLine.SetRMBpoint(xOpenGL, yOpenGL);
                Refresh();
            }
        }
    }
}


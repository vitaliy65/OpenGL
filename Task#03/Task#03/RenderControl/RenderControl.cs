using System;

namespace Task_03
{
    public partial class RenderControl : OpenGL
    {
        FigureController figureController;
        int _ParentWidth = 0;
        int _ParentHeight = 0;
        public RenderControl()
        {
            InitializeComponent();
            figureController = new FigureController();
        }

        public void setSize(int parentWidth, int parentHeight)
        {
            _ParentWidth = parentWidth;
            _ParentHeight = parentHeight;
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            figureController.SetView(_ParentWidth, _ParentHeight);
            figureController.DrawFunction();
        }
    }
}


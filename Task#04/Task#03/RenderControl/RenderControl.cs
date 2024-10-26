using System;

namespace Task_04
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
            if (FigureController._xMin != 0 && FigureController._xMax != 0 && FigureController._numPoints != 0)
            {
                figureController.SetView(_ParentWidth, _ParentHeight);
                figureController.DrawFunction();
            }
        }
    }
}


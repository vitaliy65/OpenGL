using Lab2.Components;
using System;

namespace Lab2
{
    public partial class RenderControl : OpenGL
    {
        FigureController controller;
        int _ParentWidth = 0;
        int _ParentHeight = 0;

        public RenderControl()
        {
            InitializeComponent();
            controller = new FigureController();
        }

        public void setSize(int parentWidth, int parentHeight)
        {
            _ParentWidth = parentWidth;
            _ParentHeight = parentHeight;
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            controller.SetView(_ParentWidth, _ParentHeight);
            controller.CreateTiles();
        }
    }
}


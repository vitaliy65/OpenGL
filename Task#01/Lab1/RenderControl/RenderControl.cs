using System;

namespace Lab1
{
    public partial class RenderControl : OpenGL
    {
        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            FigureCreator figureCreator = new FigureCreator();
            figureCreator.SetViewPort(-5, -2, 6, 4);
            figureCreator.CreateDiamond();
        }
    }
}


using System;
using Task_05.Components;
using System.Windows.Forms;
using System.Reflection;

namespace Task_05
{
    public partial class RenderControl : OpenGL
    {
        private GridView _gridView;
        public Model _model;
        private MouseViewInteraction _mouseViewInteraction;

        public RenderControl()
        {
            InitializeComponent();
            _gridView = new GridView();
            _mouseViewInteraction = new MouseViewInteraction();
            _model = new Model();

            _gridView.showText = DrawText;
            MouseWheel += RenderControl_MouseWheel;
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            _gridView.SetView(Width, Height, SetViewRotation, SetViewScale);
            _model.RenderModel();
        }

        public void SetViewRotation()
        {
            _gridView.SetRotation(_mouseViewInteraction.RotationX, 1, 0, 0);  // Rotate around X-axis
            _gridView.SetRotation(_mouseViewInteraction.RotationY, 0, 1, 0);  // Rotate around Y-axis
        }
        public void SetViewScale() =>
            _gridView.SetScale(_mouseViewInteraction.Scale);

        private void RenderControl_MouseMove(object sender, MouseEventArgs e)
        {
            _mouseViewInteraction.HandleMouseMove(e);
            _mouseViewInteraction.UpdateLastMousePosition(e.X, e.Y);

            Invalidate();
        }
        private void RenderControl_MouseWheel(object sender, MouseEventArgs e)
        {
            _mouseViewInteraction.HandleMouseScale(e);
            Invalidate();
        }
    }
}
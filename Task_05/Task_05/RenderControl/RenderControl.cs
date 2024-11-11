using System;
using Task_05.Components;
using System.Windows.Forms;

namespace Task_05
{
    public partial class RenderControl : OpenGL
    {
        private GridView _gridView;
        private MouseViewInteraction _mouseViewInteraction;
        private Sphere sphere;
        private Cylinder cylinder;
        private Disk disk;
        public IntPtr quadric;

        public bool fillFigure = false;

        uint id0 = 0;

        public RenderControl()
        {
            InitializeComponent();
            _gridView   = new GridView();
            _mouseViewInteraction = new MouseViewInteraction();
            sphere      = new Sphere();
            cylinder    = new Cylinder();
            disk        = new Disk();
            _gridView.showText = DrawText;

            quadric = gluNewQuadric();

            MouseWheel += RenderControl_MouseWheel;
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            //glClipPlane
            CreateGridList();
            glCallList(id0);

            if (fillFigure)
            {
                initLighting();
                initCulling();
            }
            else
            {
                glDisable(GL_LIGHTING);
            }


            gluQuadricDrawStyle(quadric, fillFigure ? GLU_FILL : GLU_LINE);
            sphere.DrawFigure(quadric, fillFigure);
            cylinder.DrawFigure(quadric, fillFigure);
            disk.DrawFigure(quadric, fillFigure);
        }

        private void CreateGridList()
        {
            id0 = glGenLists(3);
            glNewList(id0, GL_COMPILE);

            _gridView.SetView(Width, Height, SetViewRotation, SetViewScale);

            glEndList();
        }

        private void initLighting()
        {
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);
            float[] lightPos = new float[] { 1.0f, 1.0f, 1.0f, 0.0f };  // Позиція світла

            glLightfv(GL_LIGHT0, GL_POSITION, lightPos);  // Встановлюємо позицію світла

            glEnable(GL_DEPTH_TEST);
            glEnable(GL_COLOR_MATERIAL);
            glColorMaterial(GL_FRONT_AND_BACK, GL_AMBIENT_AND_DIFFUSE); // Применяем цвет к передней и задней стороне
            glLightModeli(GL_LIGHT_MODEL_TWO_SIDE, 1);
        }
        void initCulling()
        {
            glEnable(GL_CULL_FACE);   // Вмикаємо відсікання граней
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
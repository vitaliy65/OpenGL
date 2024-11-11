using static Task_05.OpenGL;

namespace Task_05.Components
{
    public delegate void ShowText(string text, double x, double y, double z = 0);
    public delegate void RenderRotation();
    public delegate void RenderScale();

    internal class GridView : IGridView
    {
        public ShowText showText;
        private int _minGridSize = 10; 
        public static int gridSize { get; set; }
        public Point gridPosition { get; set; } = new Point(5,5,5);
        public bool usePerspective = false;

        public GridView()
        {
            gridSize = _minGridSize;
        }

        public void ShowGrid()
        {
            CreateAxis();
            CreateFlatGround();
            CreateGridText();
        }
        private void CreateAxis()
        {
            float x0 = gridPosition.X;
            float y0 = gridPosition.Y;
            float z0 = gridPosition.Z;

            glLineWidth(2);
            glColor3b(127, 127, 127);

            glLineStipple(1, 0x00FF);
            glEnable(GL_LINE_STIPPLE);

            glBegin(GL_LINES);
            glVertex3d(x0,               y0,                z0);
            glVertex3d(x0 + gridSize,    y0,                z0);
            glVertex3d(x0,               y0,                z0);
            glVertex3d(x0,               y0 + gridSize,     z0);
            glVertex3d(x0,               y0,                z0);
            glVertex3d(x0,               y0,                z0 + gridSize);

            glVertex3d(x0,               y0,                z0);
            glVertex3d(x0 + (-gridSize), y0,                z0);
            glVertex3d(x0,               y0,                z0);
            glVertex3d(x0,               y0 + (-gridSize),  z0);
            glVertex3d(x0,               y0,                z0);
            glVertex3d(x0,               y0,                z0 + (-gridSize));

            glEnd();
            glDisable(GL_LINE_STIPPLE);


            // main axis
            glBegin(GL_LINES);
            glVertex3d(0, gridSize, 0);
            glVertex3d(0, -gridSize, 0);
            glEnd();
        }
        private void CreateFlatGround()
        {
            float x0 = gridPosition.X;
            float y0 = gridPosition.Y;
            float z0 = gridPosition.Z;

            glBegin(GL_LINE_LOOP);
            glVertex3d(x0 +  gridSize, y0, z0 +  gridSize);
            glVertex3d(x0 + -gridSize, y0, z0 +  gridSize);
            glVertex3d(x0 + -gridSize, y0, z0 + -gridSize);
            glVertex3d(x0 +  gridSize, y0, z0 + -gridSize);
            glEnd();
        }
        private void CreateGridText()
        {
            float x0 = gridPosition.X;
            float y0 = gridPosition.Y;
            float z0 = gridPosition.Z;

            glColor3b(126, 0, 0);
            showText.Invoke("X", x0 + gridSize, y0 + 0.2f,            z0);
            showText.Invoke("Y", x0,            y0 + gridSize + 0.2f, z0);
            showText.Invoke("Z", x0,            y0 + 0.2f,            z0 + gridSize);

            showText.Invoke("Main Axis", 0, gridSize + 0.4f, 0);
        }

        public void SetView(int width, int height, RenderRotation rotation, RenderScale scale)
        {
            
            double x1 = -gridSize;
            double x2 = gridSize;
            double y1 = -gridSize;
            double y2 = gridSize;

            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            if (width > height)
                glViewport((width - height) / 2, 0, height, height);
            else
                glViewport(0, (height - width) / 2, width, width);

            if(!usePerspective)
                glOrtho(x1 - 1, x2 + 1, y1 - 1, y2 + 1, -gridSize * 3, gridSize * 3);
            else
            {
                gluPerspective(50, (double)width/height, 1, 100);
                gluLookAt(3.0, 3.0, 3.0,   // Camera position
                          0.0, 0.0, 0.0,   // Look at point (origin)
                          0.0, 1.0, 0.0);  // Up direction (y-axis)
            }

            rotation.Invoke();
            scale.Invoke();
            ShowGrid();
        }

        public void SetRotation(double angle, int x, int y, int z) => glRotated(angle, x, y, z);
        public void SetScale(double scaleFactor) => glScaled(scaleFactor, scaleFactor, scaleFactor);
        public void SetGridSize(int size) => gridSize = size >= _minGridSize ? size : _minGridSize;
    }
}

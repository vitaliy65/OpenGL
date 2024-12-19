using static Task_05.OpenGL;

namespace Task_05.Components
{
    public delegate void ShowText(string text, double x, double y, double z = 0);
    public delegate void RenderRotation();
    public delegate void RenderScale();

    internal class GridView : IGridView
    {
        public ShowText showText;
        private int _minGridSize = 2; 
        public static int gridSize { get; set; }
        public Point gridPosition { get; set; } = new Point(0, 0, 0);

        public GridView()
        {
            gridSize = _minGridSize;
            gridPosition = new Point(-gridSize / 2, -gridSize / 2, -gridSize / 2);
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
            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }
        private void CreateFlatGround()
        {
            float tempGridSize = gridSize;
            float offset = 0.2f;
            float x0 = gridPosition.X;
            float y0 = gridPosition.Y;
            float z0 = gridPosition.Z;

            glBegin(GL_LINE_LOOP);
            glVertex3d(x0 + offset,                 y0,                         z0 + offset);
            glVertex3d(x0 + offset,                 y0,                         z0 + tempGridSize + offset);
            glVertex3d(x0 + tempGridSize + offset,  y0,                         z0 + tempGridSize + offset);
            glVertex3d(x0 + tempGridSize + offset,  y0,                         z0 + offset);
            glEnd();

            glBegin(GL_LINE_LOOP);
            glVertex3d(x0 + offset,                 y0 + offset,                z0);
            glVertex3d(x0 + offset,                 y0 + tempGridSize + offset, z0);
            glVertex3d(x0 + tempGridSize + offset,  y0 + tempGridSize + offset, z0);
            glVertex3d(x0 + tempGridSize + offset,  y0 + offset,                z0);
            glEnd();

            glBegin(GL_LINE_LOOP);
            glVertex3d(x0,                          y0 + offset, z0 + offset);
            glVertex3d(x0,                          y0 + tempGridSize + offset, z0 + offset);
            glVertex3d(x0,                          y0 + tempGridSize + offset, z0 + tempGridSize + offset);
            glVertex3d(x0,                          y0 + offset,                z0 + tempGridSize + offset);
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

            glOrtho(x1 - 1, x2 + 1, y1 - 1, y2 + 1, -gridSize * 3, gridSize * 3);

            rotation.Invoke();
            scale.Invoke();
            ShowGrid();
        }

        public void SetRotation(double angle, int x, int y, int z) => glRotated(angle, x, y, z);
        public void SetScale(double scaleFactor) => glScaled(scaleFactor, scaleFactor, scaleFactor);
    }
}

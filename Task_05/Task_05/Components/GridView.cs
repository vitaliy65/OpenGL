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
            glLineWidth(2);
            glColor3b(127, 127, 127);

            glLineStipple(1, 0x00FF);
            glEnable(GL_LINE_STIPPLE);

            glBegin(GL_LINES);
            glVertex3d(0, 0, 0);
            glVertex3d(gridSize, 0, 0);
            glVertex3d(0, 0, 0);
            glVertex3d(0, gridSize, 0);
            glVertex3d(0, 0, 0);
            glVertex3d(0, 0, gridSize);

            glVertex3d(0, 0, 0);
            glVertex3d(-gridSize, 0, 0);
            glVertex3d(0, 0, 0);
            glVertex3d(0, -gridSize, 0);
            glVertex3d(0, 0, 0);
            glVertex3d(0, 0, -gridSize);

            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }
        private void CreateFlatGround()
        {
            glBegin(GL_LINE_LOOP);
            glVertex3d(gridSize, 0, gridSize);
            glVertex3d(-gridSize, 0, gridSize);
            glVertex3d(-gridSize, 0, -gridSize);
            glVertex3d(gridSize, 0, -gridSize);
            glEnd();
        }
        private void CreateGridText()
        {
            glColor3b(126, 0, 0);
            showText.Invoke("X", gridSize, 0.2f, 0);
            showText.Invoke("Y", 0, gridSize + 0.2f, 0);
            showText.Invoke("Z", 0, 0.2f, gridSize);
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
            //glFrustum(x1 - 1, x2 + 1, y1 - 1, y2 + 1, -gridSize * 3, gridSize * 3);
            //gluPerspective(50 , 1, gridSize * 3, gridSize * 3);

            rotation.Invoke();
            scale.Invoke();
            ShowGrid();
        }

        public void SetRotation(double angle, int x, int y, int z) => glRotated(angle, x, y, z);
        public void SetScale(double scaleFactor) => glScaled(scaleFactor, scaleFactor, scaleFactor);
        public void SetGridSize(int size) => gridSize = size >= _minGridSize ? size : _minGridSize;
    }
}

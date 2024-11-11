using System;
using static Task_05.OpenGL;


namespace Task_05.Components
{
    internal class Cylinder : AFigure
    {
        private int _height = 1;
        public  int Height { get => _height; set => _height = value; }

        public Cylinder()
        {
            center = new Point(4.5f, -3.5f, -4f);
            radius = 4;
        }

        public override void DrawFigure(IntPtr quadric, bool fillEnable)
        {
            SetMaterial();
            initCulling();
            glColor3b(0, 0, 126);

            glEnable(GL_COLOR_MATERIAL);

            glTranslatef(center.X, center.Y, center.Z);
            glRotated(90, 1, 0, 0);

            //gluQuadricDrawStyle(quadric, fillEnable ? GLU_FILL : GLU_LINE); // Устанавливаем стиль отрисовки
            gluCylinder(quadric, radius, radius, _height, 32, 4);     // Отрисовываем c 32 долготами и широтами

            //gluDeleteQuadric(quadric);  // Освобождаем память
            //wglSwapBuffers(quadric);
        }

        private void SetMaterial()
        {
            
        }

        void initCulling()
        {
            glDisable(GL_CULL_FACE);   // Вмикаємо відсікання граней
        }
    }
}

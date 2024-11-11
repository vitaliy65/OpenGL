using System;
using System.Runtime.InteropServices;
using static Task_05.OpenGL;

namespace Task_05.Components
{
    internal class Sphere : AFigure
    {
        public Sphere()
        {
            center = new Point(2, 1.5f, 2);
            radius = 2;
        }

        public override void DrawFigure(IntPtr quadric, bool fillEnable)
        {
            SetMaterial();
            SetTexture();
            glColor3b(0, 0, 126);

            glTranslatef(center.X, center.Y, center.Z);

            //gluQuadricDrawStyle(quadric, fillEnable ? GLU_FILL : GLU_LINE);
            gluSphere(quadric, radius, 32, 32);

            //gluDeleteQuadric(quadric);  // Освобождаем память
            //wglSwapBuffers(quadric);
        }

        private void SetTexture()
        {

        }

        private void SetMaterial()
        {
            float shininess = 50.0f;
            glMaterialf(GL_FRONT, GL_SHININESS, shininess); // Встановлюємо блискучість
        }
    }
}

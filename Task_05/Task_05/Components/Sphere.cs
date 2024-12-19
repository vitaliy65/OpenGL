using System;
using System.Drawing.Imaging;
using System.Drawing;
using static Task_05.OpenGL;

namespace Task_05.Components
{
    internal class Sphere : AFigure
    {
        uint textureId = 0;

        public Sphere()
        {
            center = new Point(2, 1.5f, 2);
            radius = 2;
        }

        public override void DrawFigure(IntPtr quadric, bool fillEnable)
        {
            SetMaterial();
            SetTexture();

            // Включаем использование текстуры для квадрики
            gluQuadricTexture(quadric, 1);

            glPushMatrix();
            glTranslatef(center.X, center.Y, center.Z);
            gluSphere(quadric, radius, 32, 32);
            glPopMatrix();

            // Отключаем текстуру после рисования
            glDisable(GL_TEXTURE_2D);
        }

        private void SetTexture()
        {
            if (textureId == 0)
            {
                textureId = LoadTexture("C:/Users/cigri/Downloads/Telegram Desktop/photo_2024-11-29_12-07-24.jpg");
            }

            glEnable(GL_TEXTURE_2D);  // Включаем 2D текстурирование
            glBindTexture(GL_TEXTURE_2D, textureId);  // Привязываем текстуру
        }

        private void SetMaterial()
        {
            float[] ambient = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] diffuse = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            glMaterialfv(GL_FRONT, GL_AMBIENT, ambient);
            glMaterialfv(GL_FRONT, GL_DIFFUSE, diffuse);
            glMaterialfv(GL_FRONT, GL_SPECULAR, new float[] { 1.0f, 1.0f, 1.0f, 1.0f });
            glMaterialf(GL_FRONT, GL_SHININESS, 0.0f);  // Без блеска
        }
    }
}

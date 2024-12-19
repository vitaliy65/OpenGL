using System;
using static Task_05.OpenGL;

namespace Task_05.Components
{
    public class Model
    {

        // Довжини сегментів
        private float a = 0.42f;   // Довжина сегмента A
        private float b = 1.0f;    // Довжина сегмента B
        private float s = 0.42f * 2; // Довжина сегмента S
        private float c = 0.56f;

        // Кути повороту
        private float angleAlpha = 0; // Кут α
        private float angleBeta = 0;  // Кут β
        private float angleGamma = 0; // Кут γ

        private float angleSigma = 0; // Кут :)

        public float AngleAlpha
        {
            get => angleAlpha;
            set
            {
                if (value <= 0 && value >= -90)
                    angleAlpha = value;
                else if (value < 0)
                    angleAlpha = -90;
                else if (value > -90)
                    angleAlpha = 0;
            }
        }
        public float AngleBeta
        {
            get => angleBeta;
            set
            {
                if (value <= 90 && value >= 0)
                    angleBeta = value;
                else if (value < 90)
                    angleBeta = 0;
                else if (value > 0)
                    angleBeta = 90;
            }
        }
        public float AngleGamma
        {
            get => angleGamma;
            set
            {
                if (value <= 0 && value >= -180)
                    angleGamma = value;
                else if (value < 0)
                    angleGamma = -180;
                else if (value > -180)
                    angleGamma = 0;
            }
        }

        public float AngleSigma
        {
            get => angleSigma;
            set
            {
                if (value <= 0 && value >= -90)
                    angleSigma = value;
                else if (value < 0)
                    angleSigma = -90;
                else if (value > -90)
                    angleSigma = 0;
            }
        }

        public float C { get => c; }

        public void UpdateAlphaAngle(float alpha)
        {
            // Оновлюємо кут Alpha
            AngleAlpha = alpha;

            // Розрахунок кута Beta
            AngleBeta = -alpha;

            // Розрахунок C (наприклад, горизонтальна проєкція)
            double theta = AngleBeta * Math.PI / 180;
            c = 2 * (float)((a + s / 2) * Math.Sin(theta) / 2);
        }
        public void UpdateSigmaAngle(float sigma) => AngleSigma = sigma;
        public void UpdateGammaAngle(float gamma) => AngleGamma = gamma;

        public void RenderModel()
        {
            glPushMatrix();

            glRotatef(AngleSigma, 0, 1, 0);
            glRotatef(AngleAlpha, 0, 0, 1);
            DrawSegment(a);
            glRotatef(-AngleAlpha, 0, 0, 1);

            glTranslatef(c, 0, 0);
            glRotatef(AngleBeta, 0, 0, 1);
            DrawSegment(s);
            glTranslatef(0, s / 2, 0);
            glRotatef(AngleGamma, 0, 0, 1);
            DrawSegment(b);
            glRotatef(AngleGamma, 0, 0, 1);
            glRotatef(-AngleBeta, 0, 0, 1);
            glTranslatef(-c, 0, 0);

            glPopMatrix();
        }

        private void DrawSegment(float size)
        {
            // Малювання відрізка як лінії
            glBegin(GL_LINE_LOOP);
            glVertex3d(0.0, 0.0, 0.0); 
            glVertex3d(0.0, 0.0, 0.2); 
            glVertex3d(0.0, size, 0.2);
            glVertex3d(0.0, size, 0.0);

            glEnd();
        }
    }
}

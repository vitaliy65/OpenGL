using System;
using static Task_05.OpenGL;

namespace Task_05.Components
{
    internal class Disk : AFigure
    {
        float innerRadius = 0;
        float outerRadius = 0;
        public float InnerRadius { get => innerRadius; set => innerRadius = value; }
        public float OuterRadius { get => outerRadius; set => outerRadius = value; }

        public Disk()
        {
            center = new Point(-2, 2, -2.5f);;
            outerRadius = 1.5f;
        }

        public override void DrawFigure(IntPtr quadric, bool fillEnable)
        {
            SetMaterial();
            initCulling();
            glColor3b(0, 0, 126);

            glEnable(GL_COLOR_MATERIAL);

            glTranslatef(center.X, center.Y, center.Z);

            gluDisk(quadric, InnerRadius, OuterRadius, 32, 2);     // Отрисовываем c 32 долготами и широтами

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

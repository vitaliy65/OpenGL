using System;
using System.Collections.Generic;
using static Task_04.OpenGL;

namespace Task_04.Components
{
    public class Elips : AFigure
    {
        public float radiusX { get; set; }
        public float radiusY { get; set; }
        public static List<Point> points { get; set; }

        public Elips()
        {
            points = new List<Point>();
        }

        public void SetRadius(int rX, int rY)
        {
            radiusX = rX;
            radiusY = rY;
        }

        public override void DrawFigure()
        {
            points.Clear();
            glColor3b(0, 127, 0);
            glBegin(GL_LINE_STRIP);

            for (int i = 0; i <= numSegments; i++)
            {
                float angle = 2.0f * 3.1415926f * i / numSegments;
                float dx = (float)(radiusX * Math.Cos(angle)); 
                float dy = (float)(radiusY * Math.Sin(angle));  
                glVertex2f(center.X + dx, center.Y + dy);        
                points.Add(new Point(center.X + dx, center.Y + dy));
            }

            glEnd();
        }
    }
}

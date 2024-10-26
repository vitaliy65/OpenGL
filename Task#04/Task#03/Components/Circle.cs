using System;
using System.Collections.Generic;
using static Task_04.OpenGL;

namespace Task_04.Components
{
    public class Circle : AFigure
    {
        public float radius { get; set; }
        public static List<Point> points { get; set; }

        public Circle() 
        {
            points = new List<Point>();
        }

        public override void DrawFigure()
        {
            points.Clear();
            glColor3b(127, 0, 0);
            glBegin(GL_LINE_STRIP);

            for (int i = 0; i <= numSegments; i++)
            {
                float angle = 2.0f * 3.1415926f * i / numSegments; 
                float dx = (float)(radius * Math.Cos(angle));
                float dy = (float)(radius * Math.Sin(angle));
                glVertex2f(center.X + dx, center.Y + dy);    
                points.Add(new Point(center.X + dx, center.Y + dy));
            }

            glEnd(); 
        }
    }
}

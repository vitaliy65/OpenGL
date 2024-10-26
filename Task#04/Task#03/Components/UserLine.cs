using System;
using System.Collections.Generic;
using static Task_04.OpenGL;

namespace Task_04.Components
{
    internal class UserLine
    {
        public Point? LMBpoint { get; set; }
        public Point? RMBpoint { get; set; }

        public UserLine() { }

        public void DrawLine()
        {
            if(LMBpoint != null && RMBpoint != null) 
            {
                glColor3b(0, 0, 0);
                glLineWidth(2);
                glBegin(GL_LINES);

                glVertex2f(LMBpoint.Value.X, LMBpoint.Value.Y);
                glVertex2f(RMBpoint.Value.X, RMBpoint.Value.Y);
                DrawCollisionPoints();

                glEnd();
            }
        }

        public void SetLMBpoint(float x, float y) => LMBpoint = new Point(x, y);

        public void SetRMBpoint(float x, float y) => RMBpoint = new Point(x, y);

        public void DrawCollisionPoints()
        {
            if (LMBpoint == null || RMBpoint == null) return;

            float threshold = 0.02f; // Допустима близькість для виявлення перетину

            foreach (var circlePoint in Circle.points)
                if (IsPointNearLine(circlePoint, LMBpoint.Value, RMBpoint.Value, threshold))
                    DrawSquareMarker(circlePoint.X, circlePoint.Y);

            foreach (var ellipsePoint in Elips.points)
                if (IsPointNearLine(ellipsePoint, LMBpoint.Value, RMBpoint.Value, threshold))
                    DrawSquareMarker(ellipsePoint.X, ellipsePoint.Y);
        }

        // Функція для перевірки, чи знаходиться точка близько до лінії
        private bool IsPointNearLine(Point point, Point lineStart, Point lineEnd, float threshold)
        {
            float distance = DistanceToLine(point, lineStart, lineEnd);
            return distance <= threshold;
        }

        // Обчислення відстані від точки до лінії
        private float DistanceToLine(Point point, Point lineStart, Point lineEnd)
        {
            float A = point.X - lineStart.X;
            float B = point.Y - lineStart.Y;
            float C = lineEnd.X - lineStart.X;
            float D = lineEnd.Y - lineStart.Y;

            float dot = A * C + B * D;
            float lenSq = C * C + D * D;
            float param = (lenSq != 0) ? dot / lenSq : -1;

            float xx, yy;

            if (param < 0)
            {
                xx = lineStart.X;
                yy = lineStart.Y;
            }
            else if (param > 1)
            {
                xx = lineEnd.X;
                yy = lineEnd.Y;
            }
            else
            {
                xx = lineStart.X + param * C;
                yy = lineStart.Y + param * D;
            }

            return (float)Math.Sqrt((point.X - xx) * (point.X - xx) + (point.Y - yy) * (point.Y - yy));
        }

        // Відображення маркерів у точках перетину
        private void DrawSquareMarker(float x, float y)
        {
            glColor3f(0, 0, 1); // Синій колір для маркера
            glPointSize(8);
            glBegin(GL_POINTS);
            glVertex2f(x, y);
            glEnd();
        }

    }
}

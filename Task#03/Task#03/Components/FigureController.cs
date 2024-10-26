using System;
using System.Linq;
using static Task_03.OpenGL;

namespace Task_03
{
    internal class FigureController : FigureControllerBase
    {
        public FigureController()
        {
            selectedF = f1;
        }

        // Implemented abstract methods
        protected override double f1(double x) => Math.Cos(3 * x + 1) / Math.Pow(Math.Cos(5 * x) + 1.21, 2);
        protected override double f2(double x) => Math.Log(Math.Sin(x)) + Math.Cos(4 * x + 1);

        protected override void SetGrid()
        {
            if (selectedF != null)
            {
                _xCoordinate = Linspace(_xMin, _xMax, _numPoints);
                _yCoordinate = new double[_xCoordinate.Length];

                for (int i = 0; i < _xCoordinate.Length; i++)
                {
                    _yCoordinate[i] = selectedF(_xCoordinate[i]);
                }
            }
        }
        protected override void drawGrid(double x1, double x2, double y1, double y2)
        {
            glLineWidth(2);
            glColor3b(0, 0, 0);
            glBegin(GL_LINES);

            if (x1 <= 0 && x2 >= 0)
            {
                glVertex2d(0, y1);
                glVertex2d(0, y2);
            }

            if (y1 <= 0 && y2 >= 0)
            {
                glVertex2d(x1, 0);
                glVertex2d(x2, 0);
            }

            glEnd();

            glLineWidth(1);
            glColor3b(100, 100, 100);

            glBegin(GL_LINES);
            for (double x = Math.Floor(x1); x <= x2; x++)
            {
                glVertex2d(x, y1);
                glVertex2d(x, y2);
            }

            for (double y = Math.Floor(y1); y <= y2; y++)
            {
                glVertex2d(x1, y);
                glVertex2d(x2, y);
            }

            glEnd();
        }
    }
}

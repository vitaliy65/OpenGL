using System;
using System.Collections.Generic;
using System.Linq;
using static Task_04.OpenGL;

namespace Task_04
{
    internal class FigureController : IFigureController
    {
        public static double _xMin = 0;
        public static double _yMin = 0;
        public static double _xMax = 0;
        public static double _yMax = 0;

        private static double[] x;
        private static double[] y;
        public static int _numPoints = 0;

        public FigureController() {}
        //Math.Cos(3 * x + 1) / Math.Pow(Math.Cos(5 * x) + 1.21, 2)
        //Math.Log(Math.Sin(x)+1) + Math.Cos(4*x+1)
        private double f1(double x) {
            return Math.Cos(3 * x + 1) / Math.Pow(Math.Cos(5 * x) + 1.21, 2);
        }

        private void SetGrid()
        {
            x = Linspace(_xMin, _xMax, _numPoints);
            y = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                y[i] = f1(x[i]);
            }
        }

        public void DrawFunction()
        {
            glLineWidth(1);
            glBegin(GL_LINE_STRIP);
            glColor3b(127, 0, 0);
            for (int i = 0; i < x.Length; i++)
            {
                glVertex2d(x[i], y[i]);
            }
            glEnd();

            DrawPoints();
        }

        // поставить точку на где y близиться у 0
        public void DrawPoints()
        {
            glPointSize(8);

            glEnable(GL_POINT_SMOOTH);
            glBegin(GL_POINTS);
            
            glColor3b(0, 0, 127);
            for (int i = 0; i < x.Length - 1; i++)
            {
                if ((y[i] > 0 && y[i + 1] < 0) || (y[i] < 0 && y[i + 1] > 0))
                {
                    double x0 = x[i];
                    double x1 = x[i + 1];
                    // находим x где y будет = 0
                    double xIntersect = FindRoot(x0, x1);
                    glColor3b(0, 0, 127);
                    glVertex2d(xIntersect, 0); // рисуем точку
                }    
            }
            glEnd();
            glDisable(GL_POINT_SMOOTH);
        }

        private double FindRoot(double x0, double x1)
        {
            double y0 = f1(x0);
            double y1 = f1(x1);
            double slope = (y1 - y0) / (x1 - x0);
            return x0 - y0 / slope;
        }

        public void SetXmax(double xMax)
        {
            _xMax = xMax;
        }

        public void SetXmin(double xMin)
        {
            _xMin = xMin;
        }

        public void SetNumPoints(int numPoints)
        {
            _numPoints = numPoints;
        }

        private void drawGrid(double x1, double x2, double y1, double y2)
        {
            // Main axis
            glLineWidth(2);
            glColor3b(0, 0, 0);
            glBegin(GL_LINES);

            // Y-axis: Draw it if it intersects with the visible area (x = 0)
            if (x1 <= 0 && x2 >= 0)
            {
                glVertex2d(0, y1);
                glVertex2d(0, y2);
            }

            // X-axis: Draw it if it intersects with the visible area (y = 0)
            if (y1 <= 0 && y2 >= 0)
            {
                glVertex2d(x1, 0);
                glVertex2d(x2, 0);
            }

            glEnd(); // End the main axis drawing

            // Drawing the grid
            glLineWidth(1);
            glColor3b(100, 100, 100); // Light gray color for the grid

            glBegin(GL_LINES);

            // Drawing vertical lines (parallel to the Y-axis)
            for (double x = Math.Floor(x1); x <= x2; x++)
            {
                glVertex2d(x, y1);
                glVertex2d(x, y2);
            }

            // Drawing horizontal lines (parallel to the X-axis)
            for (double y = Math.Floor(y1); y <= y2; y++)
            {
                glVertex2d(x1, y);
                glVertex2d(x2, y);
            }

            glEnd(); // End the grid drawing
        }

        public void SetView(int width, int height)
        {
            if ( _xMin != 0 && _xMax != 0 && _xMin < _xMax)
            {
                SetGrid();
                _yMin = y.Min();
                _yMax = y.Max();

                double x1 = _xMin;
                double x2 = _xMax;
                double y1 = _yMin;
                double y2 = _yMax;

                glClear(GL_COLOR_BUFFER_BIT);
                glLoadIdentity();

                glViewport(0, 0, width, height);
                glOrtho(x1, x2, y1, y2, -1.0, 1.0);

                drawGrid(x1,x2,y1,y2);
            }
            else
            {
                throw new Exception("Не правильно виставлені Xmin та Xmax");
            }
        }

        static double[] Linspace(double start, double end, int num)
        {
            double[] result = new double[num];
            double step = (end - start) / (num - 1);

            for (int i = 0; i < num; i++)
            {
                result[i] = Math.Round(start + i * step, 4);
            }

            return result;
        }
    }
}

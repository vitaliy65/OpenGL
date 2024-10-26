using System.Linq;
using System;
using static Task_03.OpenGL;
using System.Windows.Forms;
using System.IO;

namespace Task_03
{
    abstract class FigureControllerBase : IFigureController
    {
        protected FigureControllerBase(){
            x = new double[0];
            y = new double[0];
        }

        protected delegate double FunctionOperation(double x);
        protected static FunctionOperation selectedF;

        public static double _xMin = 0;
        public static double _yMin = 0;
        public static double _xMax = 0;
        public static double _yMax = 0;

        protected static double[] x;
        protected static double[] y;
        public static int _numPoints = 0;

        // Abstract methods
        protected abstract double f1(double x);
        protected abstract double f2(double x);
        protected abstract void SetGrid();
        protected abstract void drawGrid(double x1, double x2, double y1, double y2);

        // Common methods
        public void SetXmax(double xMax) => _xMax = xMax;
        public void SetXmin(double xMin) => _xMin = xMin;
        public void SetYmax(double yMax) => _yMax = yMax;
        public void SetYmin(double yMin) => _yMin = yMin;
        public void SetNumPoints(int numPoints) => _numPoints = numPoints;

        public void SelectFunction(string F) => selectedF = F == "f1" ? f1 : (F == "f2" ? f2 : null);

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

            glColor3b(127, 127, 0);
            glLineStipple(1, 0x00FF);
            glEnable(GL_LINE_STIPPLE);
            glBegin(GL_LINES);
            for (int i = 0; i < x.Length; i++)
            {
                DrawRip(x[i]);
            }
            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }
        public void DrawPoints()
        {
            if (selectedF != null)
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
                        double xIntersect = FindRoot(x0, x1);
                        glColor3b(0, 0, 127);
                        glVertex2d(xIntersect, 0); // Draw intersection point
                    }
                }
                glEnd();
                glDisable(GL_POINT_SMOOTH);
            }
        }
        public void DrawRip(double x)
        {
            if (selectedF.Method.ToString().Contains("f2"))
            {
                if (Math.Sin(x) + 1 < 0)
                {
                    glVertex2d(x, _yMax);
                    glVertex2d(x, _yMin);
                }
            }
        }
        protected double FindRoot(double x0, double x1)
        {
            double y0 = selectedF(x0);
            double y1 = selectedF(x1);
            double slope = (y1 - y0) / (x1 - x0);
            return x0 - y0 / slope;
        }


        public void SetView(int width, int height)
        {
            if (_xMin < _xMax && _numPoints != 0 &&
               ((_yMin < _yMax) || (_yMin == 0 && _yMax == 0)))
            {
                SetGrid();
                if(_yMin == 0 && _yMax == 0)
                {
                    SetYmin(y.Min());
                    SetYmax(y.Max());
                }


                double x1 = _xMin;
                double x2 = _xMax;
                double y1 = _yMin;
                double y2 = _yMax;

                glClear(GL_COLOR_BUFFER_BIT);
                glLoadIdentity();

                glViewport(0, 0, width, height);
                glOrtho(x1, x2, y1, y2, -1.0, 1.0);

                drawGrid(x1, x2, y1, y2);
                _yMin = 0;
                _yMax = 0;
            }
            else
            {
                MessageBox.Show("Xmin and Xmax values are not set correctly.");
            }
        }

        protected static double[] Linspace(double start, double end, int num)
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

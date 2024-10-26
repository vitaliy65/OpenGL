using System;
using static Task_04.OpenGL;

namespace Task_04
{
    internal class ViewController : IViewController
    {
        public static double _xMin = 0;
        public static double _yMin = 0;
        public static double _xMax = 0;
        public static double _yMax = 0;

        public ViewController() {}

        // поставить точку на где y близиться у 0
        //public void DrawPoints()
        //{
        //    glPointSize(8);

        //    glEnable(GL_POINT_SMOOTH);
        //    glBegin(GL_POINTS);

        //    glColor3b(0, 0, 127);
        //    for (int i = 0; i < x.Length - 1; i++)
        //    {
        //        if ((y[i] > 0 && y[i + 1] < 0) || (y[i] < 0 && y[i + 1] > 0))
        //        {
        //            double x0 = x[i];
        //            double x1 = x[i + 1];
        //            // находим x где y будет = 0
        //            double xIntersect = FindRoot(x0, x1);
        //            glColor3b(0, 0, 127);
        //            glVertex2d(xIntersect, 0); // рисуем точку
        //        }    
        //    }
        //    glEnd();
        //    glDisable(GL_POINT_SMOOTH);
        //}

        //private double FindRoot(double x0, double x1)
        //{
        //    double y0 = f1(x0);
        //    double y1 = f1(x1);
        //    double slope = (y1 - y0) / (x1 - x0);
        //    return x0 - y0 / slope;
        //}

        public void drawGrid(double x1, double x2, double y1, double y2)
        {
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


            // Main axis
            glLineWidth(3);
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
        }

        public void SetView(int width, int height)
        {
            if ( _xMin != 0 && _xMax != 0 && _xMin < _xMax)
            {
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
    }
}

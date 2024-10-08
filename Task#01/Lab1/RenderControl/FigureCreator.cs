using System;
using System.Drawing;
using static Lab1.OpenGL;
using static System.Windows.Forms.Form;

namespace Lab1
{
    internal class FigureCreator
    {


        public FigureCreator() { }

        public void CreateDiamond()
        {
            DrawDiamondLines(5, GL_LINE_STRIP, 0, 0, 0);

            DrawDiamondPoints(5, GL_POINTS, 0, 0, 0);
        }

        private void DrawDiamondPoints(int pointSize, uint mode, sbyte red, sbyte green, sbyte blue)
        {
            Color color = Color.White;
            glPointSize(pointSize);
            glBegin(mode);
            glColor3b(red, green, blue);

            glVertex2d(1, 1);
            glVertex2d(3, -1);
            glVertex2d(3, 3);
            glVertex2d(4, 0);
            glVertex2d(4, 2);

            glEnd();
        }

        private void DrawDiamondLines(int lineSize, uint mode, sbyte red, sbyte green, sbyte blue)
        {
            glLineWidth(lineSize);
            glBegin(mode);
            glColor3b(red, green, blue);

            glVertex2d(-4, 1);
            glVertex2d(-2, 3);
            glVertex2d(-1, 2);
            glVertex2d(-1, 0);
            glVertex2d(-2, -1);
            glVertex2d(-4, 1);

            glEnd();
        }

        public void SetViewPort(int x1, int y1, int x2, int y2)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, ActiveForm.Width, ActiveForm.Height);
            glOrtho(x1, x2, y1, y2, -1, 1);

            glColor3b(0, 0, 0);
            glLineWidth(1);
            glLineStipple(1, 0x00F0);
            glEnable(GL_LINE_STIPPLE);
            glBegin(GL_LINES);
            for (int x = x1; x < x2; x++)
            {
                glVertex2d(x, y1);
                glVertex2d(x, y2);
            }

            for (int y = y1; y < y2; y++)
            {
                glVertex2d(x1, y);
                glVertex2d(x2, y);
            }
            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }

    }
}

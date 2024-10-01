using System;
using static Lab2.OpenGL;

namespace Lab2.Components
{
    internal class FigureController : IFigureController
    {
        private float a = 8.5f;
        private int _minTileCountX = 1;
        private int _minTileCountY = 1;
        private static int _tileCountX = 1;
        private static int _tileCountY = 1;

        private static uint _mode = GL_FILL;

        public FigureController() { }

        // Отрисовка фигуры (шаблон)
        public void DrawShape(float xOffset, float yOffset)
        {
            glLineWidth(5);
            glPointSize(5);

            glPolygonMode(GL_FRONT_AND_BACK, _mode);
            // Синій квадрат
            glBegin(GL_POLYGON);
            glColor3b(0, 0, 127);
            glVertex2d(xOffset, yOffset);
            glVertex2d(xOffset + a, yOffset);
            glVertex2d(xOffset + a, yOffset + a);
            glVertex2d(xOffset, yOffset + a);
            glEnd();

            // білий + червоний трикутники
            glShadeModel(GL_FLAT);
            glBegin(GL_TRIANGLE_STRIP);
            glColor3b(127, 127, 127);
            glVertex2d(xOffset, yOffset + a);
            glVertex2d(xOffset + a / 2, yOffset + a + a / 2);
            glVertex2d(xOffset + a, yOffset + a);
            glColor3b(127, 0, 0);
            glVertex2d(xOffset + a + a / 2, yOffset + a + a / 2);
            glEnd();

            // білий + червоний трикутники
            glShadeModel(GL_FLAT);
            glBegin(GL_TRIANGLE_STRIP);
            glColor3b(127, 127, 127);
            glVertex2d(xOffset + a, yOffset + a);
            glVertex2d(xOffset + a + a / 2, yOffset + a / 2);
            glVertex2d(xOffset + a, yOffset);
            glColor3b(127, 0, 0);
            glVertex2d(xOffset + a + a / 2, yOffset - a / 2);
            glEnd();

            // Зелений квадрат
            glBegin(GL_POLYGON);
            glColor3b(0, 127, 0);
            glVertex2d(xOffset + a, yOffset + a);
            glVertex2d(xOffset + a + a / 2, yOffset + a / 2);
            glVertex2d(xOffset + a + a, yOffset + a);
            glVertex2d(xOffset + a + a / 2, yOffset + a + a / 2);
            glEnd();
        }

        // Создание нескольких плиток (по сетке)
        public void CreateTiles()
        {
            glClear(GL_COLOR_BUFFER_BIT);

            float xOffseti = 0;
            float yOffseti = 0;
            float xOffsetj = 0;
            float yOffsetj = 0;

            for (int i = 0; i < _tileCountY; i++)
            {
                xOffsetj = xOffseti;
                yOffsetj = yOffseti;
                for (int j = 0; j < _tileCountX; j++)
                {
                    if(j != 0)
                    {
                        xOffsetj += a + a / 2;
                        yOffsetj -= a / 2;
                    }

                    DrawShape(xOffsetj, yOffsetj);
                }
                xOffseti -= a / 2;
                yOffseti -= a + a / 2;
            }
        }

        public void SetDefaultMode()
        {
            _mode = GL_FILL;
        }

        public void SetMode(uint mode)
        {
            _mode = mode;
        }

        // Задание количества плиток по X и Y
        public void SetTilesCount(int tileCountX, int tileCountY)
        {
            if (tileCountX >= _minTileCountX && tileCountY >= _minTileCountY)
            {
                _tileCountX = tileCountX;
                _tileCountY = tileCountY;
            }
            else
                throw new ArgumentOutOfRangeException();
        }

        // Настройка области просмотра и ортографической проекции
        public void SetView(int width, int height)
        {
            float x1 = 0;
            float x2 = a * 2;
            float y1 = -a / 2;
            float y2 = a * 1.5f;

            if (_tileCountY != 1)
            {
                x1 += -a * (_tileCountY - 1);
                x2 += a / 2 * (_tileCountY - 1);
            }

            if (_tileCountX != 1)
                y1 -= a * (_tileCountX - 1);
            if (_tileCountY != 1)
                y1 -= a * 1.5f * (_tileCountY - 1);

            if (_tileCountX != 1)
            {
                x2 += a * 1.5f * (_tileCountX - 1);
                y2 += a / 2 * (_tileCountX - 1);
            }

            glViewport(0, 0, width, height);
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();

            // Пропорции области видимости
            if (width >= height)
            {
                float aspect = (float)width / height;
                // Устанавливаем границы с отступами
                glOrtho(x1 * aspect,
                        x2 * aspect,
                        y1,
                        y2,
                        -1.0, 1.0);
            }
            else
            {
                float aspect = (float)height / width;
                // Устанавливаем границы с отступами
                glOrtho(x1,
                        x2,
                        y1 * aspect,
                        y2 * aspect,
                       - 1.0, 1.0);
            }
        }

    }
}
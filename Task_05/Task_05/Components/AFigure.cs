using System;
using System.Drawing.Imaging;
using System.Drawing;
using static Task_05.OpenGL;

namespace Task_05.Components
{
    struct Point
    {
        public float X;
        public float Y;
        public float Z;

        public Point()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Point(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    abstract class AFigure
    {
        public Point center { get; set; }
        public float radius { get; set; }

        protected AFigure() { }

        public abstract void DrawFigure(IntPtr quadric, bool fillEnable);

        // Метод для загрузки текстуры
        public uint LoadTexture(string filePath)
        {
            uint[] textures = new uint[1];  // Массив для текстуры
            glGenTextures(1, textures);  // Создаем текстуру
            uint texture = textures[0];  // Получаем идентификатор текстуры

            // Загружаем изображение (можно использовать свою библиотеку для загрузки)
            Bitmap bitmap = new Bitmap(filePath);
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            glBindTexture(GL_TEXTURE_2D, texture);  // Привязываем созданную текстуру
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);
            glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, bitmap.Width, bitmap.Height, 0, GL_BGRA_EXT, (uint)GL_UNSIGNED_BYTE, bitmapData.Scan0);

            bitmap.UnlockBits(bitmapData);
            bitmap.Dispose();

            return texture;
        }

    }
}

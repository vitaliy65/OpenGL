using System;

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
    }
}

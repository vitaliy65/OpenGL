namespace Task_04.Components
{
    public struct Point
    {
        public float X;
        public float Y;

        public Point(float x = 0, float y = 0)
        {
            X = x;
            Y = y;
        }
    }

    public abstract class AFigure
    {
        public Point center { get; set; }
        public float width {  get; set; }
        public float height { get; set; }
        public const int numSegments = 2000;

        public AFigure() { center = new Point(); }

        public AFigure(Point center) { this.center = center; }

        public abstract void DrawFigure();
    }
}

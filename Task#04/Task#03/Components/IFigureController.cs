namespace Task_04
{
    internal interface IFigureController
    {
        void SetView(int width, int height);
        void DrawFunction();
        void SetXmin(double xMin);
        void SetXmax(double xMax);
        void SetNumPoints (int numPoints);
    }
}

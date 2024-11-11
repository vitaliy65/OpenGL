namespace Task_05.Components
{
    internal interface IGridView
    {
        void ShowGrid();
        void SetView(int width, int height, RenderRotation rotation, RenderScale scale);
        void SetRotation(double angle, int x, int y, int z);
        void SetScale(double scaleFactor);
    }
}

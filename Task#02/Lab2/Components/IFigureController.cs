using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Components
{
    internal interface IFigureController
    {
        void SetView(int width, int height);
        void DrawShape(float xOffset, float yOffset);
        void CreateTiles();
        void SetDefaultMode();
        void SetMode(uint mode);
        void SetTilesCount(int tileCountX, int tileCountY);
    }
}

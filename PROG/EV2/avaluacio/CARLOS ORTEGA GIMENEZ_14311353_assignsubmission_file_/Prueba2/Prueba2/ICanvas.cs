using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    public interface ICanvas
    {
        public int Width { get; }
        public int Height { get; }
        public color CurrentColor { get;}

        public void SetColor(color color);
        public void DrawRectangle(Rectd2D rect);
        public void DrawCircle(Rectd2D rectd2D);
        public void DrawPolygon(Point2D[] point);

    }
}

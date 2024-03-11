using System.Drawing;

namespace Prueba2
{
    public class CanvasConsole : ICanvas
    {
        public int Width => 0;

        public int Height => 0;

        // Javi: O sea, que cada vez que te pido qué color tiene el canvas, me devuelves uno nuevo
        public color CurrentColor => new color();

        public void DrawCircle(Rectd2D rectd2D)
        {
           if(rectd2D != null)
           DrawRectangle(rectd2D);
        }

        // Javi: No implementada
        public void DrawPolygon(Point2D[] points)
        {
            
        }

        public void DrawRectangle(Rectd2D rect)
        {
            if(rect != null)
            {
                Console.WriteLine(rect.x);
                Console.WriteLine(rect.y);
                Console.WriteLine(rect.width);
                Console.WriteLine(rect.heigth);
            }
        }

        public void SetColor(color color)
        {
            // Javi: Claro, ..., como current color te devuelve un color nuevo, ...
            // Javi: No tiene sentido
            CurrentColor.r = color.r;
            CurrentColor.g = color.g;
            CurrentColor.b = color.b;
            CurrentColor.a = color.a;
        }
    }
}

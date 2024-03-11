using Examen2;
using System.Drawing;

namespace Prueba3
{
    public interface IShape
    {
        string? Name { get; set; }
        // Javi: Esto te pasa por el System.Drawing, pero bueno, lo has resuelto bien
        Examen2.Color Color { get; set;}
        bool Hasarea { get;}
        double Area { get;}
        double Perimeter { get;}
        Examen2.Point2D Center { get;}
        Examen2.Rect2D Rect { get;} 
        void Draw(ICanvas canvas);
    }
}

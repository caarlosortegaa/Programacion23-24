using Examen2;

namespace Prueba3
{
    public class Circle : Shape
    {
        Point2D center = new Point2D();
        public double radius { get; set; }

        public override Point2D Center => GetCenter();

        public override Rect2D? Rect => GetRect2D();

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawCircle(Rect);
        }

        public override double GetArea()
        {
            return Math.PI * (radius * radius);
        }

        public override Point2D GetCenter()
        {
            return Center;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * (radius * radius);
        }

        public override Rect2D? GetRect2D()
        {
            return new Rect2D()
            {
                MinX = center.X - radius,
                MaxX = center.X + radius,
                MinY = center.Y - radius,
                MaxY = center.Y + radius
            };
        }

        public override bool HasArea()
        {
            return true;
        }
    }
}

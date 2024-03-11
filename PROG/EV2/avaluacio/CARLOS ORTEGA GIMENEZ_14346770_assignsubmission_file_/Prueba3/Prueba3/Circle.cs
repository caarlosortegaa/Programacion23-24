using Examen2;

namespace Prueba3
{
    public class Circle : Shape
    {
        Point2D center = new Point2D();
        Point2D radius = new Point2D();
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawCircle(Rect);
        }

        public override double GetArea()
        {
            var rect = new Point2D[2];
            rect[0] = center;
            rect[1] = radius;

            return Math.PI * (rect[1].X - center.X) * 2;
        }

        public override Point2D GetCenter()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public override Rect2D? GetRect2D()
        { 
            throw new NotImplementedException();
        }

        public override bool HasArea()
        {
            return true;
        }
    }
}

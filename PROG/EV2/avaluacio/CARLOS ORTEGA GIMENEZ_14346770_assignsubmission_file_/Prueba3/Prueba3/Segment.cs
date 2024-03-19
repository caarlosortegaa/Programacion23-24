using Examen2;
namespace Prueba3
{
    public class Segment : Shape
    {
        Point2D a = new Point2D();
        Point2D b = new Point2D();
        private Point2D[] _points => new Point2D[2] {a , b};

        public override Point2D Center => GetCenter();

        public override Rect2D? Rect => GetRect2D();

        public override void Draw(ICanvas canvas)
        {
            Point2D[] point2Ds = new Point2D[2];
            
            canvas.DrawPolygon(point2Ds);
        }

        public override double GetArea()
        {
            return 0;
        }

        public override Point2D GetCenter()
        {
            Point2D center = new Point2D();
            center.X = a.X - b.X;
            return center;
        }

        public override double GetPerimeter()
        {
            return 0;
        }

        public override Rect2D? GetRect2D()
        {
            return Utils.GetBoundingBox(_points);
        }

        public override bool HasArea()
        {
            return false;
        }
    }
}

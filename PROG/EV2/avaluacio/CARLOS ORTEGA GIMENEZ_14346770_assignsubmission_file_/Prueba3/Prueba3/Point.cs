using Examen2;


namespace Prueba3
{
    public class Point : Shape
    {
        public int x, y;
        public override Point2D Center => GetCenter();

        public override Rect2D? Rect => GetRect2D();

        public override double GetArea()
        {
            return 0;
        }

        public override Point2D GetCenter()
        {
            return new Point2D()
            {
                X = x,
                Y = y
            };
        }

        public override double GetPerimeter()
        {

            return 0;               
        }

        public override Rect2D? GetRect2D()
        {
            var points = new Point2D[1];
            points[0] = new Point2D()
            {
                X = x,
                Y = y
            };
            return Utils.GetBoundingBox(points);
        }

        public override bool HasArea()
        {
            return false;
        }
    }
}

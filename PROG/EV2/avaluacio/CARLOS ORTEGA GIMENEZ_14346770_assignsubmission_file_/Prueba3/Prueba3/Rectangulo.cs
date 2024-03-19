using Examen2;

namespace Prueba3
{
    public class Rectangulo : Shape
    {
        public double x1, x2;
        public double y1, y2;

        public override Point2D Center => GetCenter();

        public override Rect2D? Rect => GetRect2D();

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRectangle(Rect);
        }

        public override double GetArea()
        {
            return Rect.Area; 
        }

        public override Point2D GetCenter()
        {
            return Rect.Center;
        }

        public override double GetPerimeter()
        {
            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y2 - y1);
            
            double perimeter = 2 * (width + height);
            return perimeter;
        }

        public override Rect2D? GetRect2D()
        {
            Point2D pointMax = new Point2D();
            {
                pointMax.X = Rect.MaxX;
                pointMax.Y = Rect.MaxY;
            }
            Point2D pointMin = new Point2D();
            {
                pointMin.X = Rect.MinX;
                pointMin.Y = Rect.MinY;
            }
            Point2D[] points = new Point2D[2];
            points[1] = pointMax;
            points[0] = pointMin;

            return Utils.GetBoundingBox(points);
        }

        public override bool HasArea()
        {
            return true;
        }
        public Point2D? GetCornerWithIndex(int index)
        {
            if(index < 0)
                return null;
            if (index == 0)
                return new Point2D() {X = x1 , Y = y1};
            if(index == 1)
                return new Point2D() {X = x1 , Y = x2};
            if(index == 2)
                return new Point2D() { X = x2, Y = y2};
            if (index == 3)
                return new Point2D(){X = x2 , Y = y1};
            return null;
        }
    }
}

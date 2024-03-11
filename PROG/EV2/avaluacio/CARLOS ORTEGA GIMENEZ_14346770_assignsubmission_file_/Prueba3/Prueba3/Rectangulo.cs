using Examen2;

namespace Prueba3
{
    public class Rectangulo : Shape
    {
        
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
            throw new NotImplementedException();
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
    }
}

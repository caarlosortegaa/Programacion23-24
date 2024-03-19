using Examen2;

namespace Prueba3
{
    public class Utils
    {
        public static double GetDistance(Point2D p1, Point2D p2)
        {
            double X = p1.X - p2.X;
            double Y = p1.Y - p2.Y;
            double distance = 0;
            return distance = Math.PI * (X * 2) * (Y * 2);
        }
        public static Rect2D GetBoundingBox(Point2D[] points)
        {
             Rect2D rect = new Rect2D();
            
                for(int i = 0; i < points.Length; i++)
                {
                }
            
            return rect;
        }
        public static double GetArea(Point2D[] points)
        {
            double area = 0;
            int First = 0;
            int Last = points.Length - 1;
            for (int i = 0; i < points.Length -1; i++)
            {
                area += ((points[i].Y + points[i + 1].Y * (points[i].X - points[i + 1].X)));
                    
            }
            area += (points[Last].Y + points[First].Y) * (points[Last].X - points[First].X);
            
            return area / 2;
        }
        public static double GetPerimeter(Point2D[] points)
        {
            double perimeter = 0;
            for(int i = 0; i < points.Length - 1; i++)
            {
                perimeter += GetDistance(points[i], points[i + 1]);
            }
            return perimeter;
        }
    }
}

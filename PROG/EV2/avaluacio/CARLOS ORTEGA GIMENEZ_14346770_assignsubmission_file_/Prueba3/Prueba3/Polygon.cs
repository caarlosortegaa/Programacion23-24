using Examen2;
namespace Prueba3
{
    public class Polygon : Shape
    {
        private Point2D[] _points = new Point2D[0];
        
        public int PointCount => _points.Length;
        
        public void Clear()
        {
            _points = new Point2D[0];
        }
        public void AddPoint(Point2D point)
        {
            Point2D[] newPoints = new Point2D[_points.Length -1];
            for(int i = 0 ; i < _points.Length; i++)
            {
                _points[i] = newPoints[i];
            }
            // Javi: EIN!?!?!?!?!?!?!?
            point = newPoints[newPoints.Length -1];
            _points = newPoints;
        }
        public Point2D? GetPoint2D(int index)
        {
            if (index < 0 || index >= _points.Length)
                return null;
            return _points[index];
        }


        public override void Draw(ICanvas canvas)
        {
            canvas.DrawPolygon(_points);
        }

        public override double GetArea()
        {
            return Utils.GetArea(_points);
            
        }

        public override Point2D GetCenter()
        {
          throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            return Utils.GetPerimeter(_points);
        }

        public override Rect2D? GetRect2D()
        {
            return Utils.GetBoundingBox(_points);
        }

        public override bool HasArea()
        {
            return true;
        }
    }
}

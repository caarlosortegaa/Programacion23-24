using Examen2;
namespace Prueba3
{
    public class Polygon : Shape
    {
        private Point2D[] _points = new Point2D[0];
        public bool IsClosed = false;

        public int PointCount => _points.Length;
        public override Point2D Center => GetCenter();
        public override Rect2D? Rect => GetRect2D();

        public void Clear()
        {
            _points = new Point2D[0];
        }
        public void Open()
        {
            IsClosed = false;
        }
        public void Close()
        {
            IsClosed = true;
        }
        public void AddPoint(Point2D point)
        {
            if (point == null)
                return;
            Point2D[] newPoints = new Point2D[_points.Length + 1];
            for(int i = 0 ; i < _points.Length; i++)
            {
                newPoints[i] = _points[i];
            }
            newPoints[_points.Length -1] = point;
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
            double MinX = 0;
            double MinY = 0;
            double MaxX = 0;
            double MaxY = 0;
            for(int i = 0; i < _points.Length; i++)
            {
                var p = _points[i];
                if(p.X < MinX)
                    MinX = p.X;
                else if(p.X > MaxX)
                    MaxX = p.X;
                if(p.Y < MinY)
                    MinY = p.Y;
                else if(p.Y > MaxY)
                    MaxY = p.Y;
            }
            return new Point2D()
            {
                X = MinX + (MaxX - MinX) / 2,
                Y = MinY + (MaxY - MinY) / 2

            };
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basura33
{
    public class PolyLine2D : ShapeWithArea
    {
        private List<Point2D> _points = new List<Point2D>();
        public void AddPoint(Point2D p)
        {
            if (p == null)
                return;
            _points.Add(p);
        }
        public void RemovePointAt(int index)
        {
            if(index < 0 || index >= _points.Count)
                return;
            _points.RemoveAt(index);
        }
        public int GetPointCount()
        {
            return _points.Count;
        }
        public Point2D? GetPointAt(int index)
        {
            if (index < 0 || index >= _points.Count)
                return null;
            return _points[index];
        }
        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.POLYLINE2D;
        }
    }
}

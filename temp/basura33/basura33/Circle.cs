

namespace basura33
{
    public class Circle : ShapeWithArea
    {
        private double _radius;
        public void SetRadius(int value)
        {
            _radius = value;
        }
        public double GetRadius()
        {
            return _radius;
        }
        public override double GetArea()
        {
            double pi = 3.1416;
            return pi * (_radius * _radius);
        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.CIRCLE2D;
        }
    }
}

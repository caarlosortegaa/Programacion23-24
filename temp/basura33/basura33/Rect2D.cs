namespace basura33
{
    public class Rect2D : ShapeWithArea
    {
        private Point2D _min = new Point2D();
        private Point2D _max = new Point2D();
        public void SetMin(Point2D min)
        {
            if (min == null)
                return;
            _min = min;
        }
        public void SetMax(Point2D max)
        {
            _max = max;
        }
        public Point2D GetMin()
        {
            return _min;
        }
        public Point2D GetMax()
        {
            return _max;
        }
        public double GetHeigth()
        {
            return _max._y - _min._y;
        }
        public double Getwidth()
        {
            return _max._x - _min._x;
        }
        public override double GetArea()
        {
            double width = Getwidth();
            double heigth = GetHeigth();
            return width * heigth;
        }

        public override ShapeType GetShapeType()
        {
            return ShapeType.RECT2D;
        }
    }
}

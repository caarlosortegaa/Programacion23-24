namespace basura33
{
    public abstract class Shape : IShape
    {
        protected Point2D _position = new Point2D();
        private string _name = "";
       
        public abstract double GetArea();

        public string GetName()
        {
            return _name;
        }

        public Point2D GetPosition()
        {
            return _position;
        }

        public abstract ShapeType GetShapeType();
        public abstract bool HasArea();
        public void SetName(string name)
        {
            if (name == null)
                return;
            _name = name;
        }

        public void SetPosition(Point2D point)
        {
            if(point == null)
                return;
            _position = point;
        }
    }
}

namespace basura33
{
    public enum ShapeType
    {
        POINT2D, SEGMENT2D, RECT2D,CIRCLE2D, POLYLINE2D
    }
    public interface IShape
    {
        Point2D GetPosition();
        void SetPosition(Point2D point);
        double GetArea();
        bool HasArea();
        ShapeType GetShapeType();
        string GetName();
        void SetName(string name);
    }
}

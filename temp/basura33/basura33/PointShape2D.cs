namespace basura33
{
    public class PointShape2D : ShapeWithoutarea
    {
       private Point2D _Point2D = new Point2D();
        public override ShapeType GetShapeType()
        {
            return ShapeType.POINT2D;
        }
    }
}

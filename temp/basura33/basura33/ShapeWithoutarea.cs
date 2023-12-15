namespace basura33
{
    public abstract class ShapeWithoutarea : Shape
    {
        public override double GetArea()
        {
            return 0;
        }
        public override bool HasArea()
        {
            return false;
        }
    }
}

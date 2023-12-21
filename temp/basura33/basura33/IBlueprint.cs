namespace basura33
{
    public interface IBlueprint
    {
        void AddShape(IShape shape);
        int GetShapeCount();
        IShape? GetShapeAt(int index);
        void RemoveShapeAt(int index);
        double GetArea();
    }
}

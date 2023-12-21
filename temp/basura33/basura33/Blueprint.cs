namespace basura33
{
    public class Blueprint : IBlueprint
    {
        private List<IShape> _Shapes = new List<IShape>();
        public void AddShape(IShape shape)
        {
            if (shape == null)
                return;
            _Shapes.Add(shape);
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public int GetShapeCount()
        {
            return _Shapes.Count;
        }

        public IShape? GetShapeAt(int index)
        {
            if(index < 0 || index >= _Shapes.Count)
                return null;
            return _Shapes[index];
        }

        public void RemoveShapeAt(int index)
        {
            if( index < 0 || index >= _Shapes.Count)
                return;
            _Shapes.RemoveAt(index);
        }
    }
}

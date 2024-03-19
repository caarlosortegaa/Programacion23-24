using Examen2;
namespace Prueba3
{
    public delegate bool FilterDelegate(IShape shape);
    public class Blueprint : IBlueprint
    {
        private List<IShape> _shapes = new List<IShape>();
        public void AddShape(IShape shape)
        {
            if(shape != null)
               _shapes.Add(shape);
        }

        public void draw(ICanvas canvas)
        {
            if (canvas != null)
            {
                for (int i = 0; i < _shapes.Count; i++)
                {
                    _shapes[i].Draw(canvas);
                }
            }
        }
        public List<IShape>? GetShapes(FilterDelegate where)
        {
            if (where == null)
                return null;
            List<IShape> shapes = new List<IShape>();
            for(int i = 0; i < _shapes.Count; i++)
            {
                if (where(_shapes[i]))
                    shapes.Add(_shapes[i]);
            }
            return shapes;
        }

        public IShape? GetShapeWithName(string name)
        {
            if (name != null)
            {
                for (int i = 0; i < _shapes.Count; i++)
                {
                    if (_shapes[i].Name == name)
                        return _shapes[i];
                }
            }
            return null;
        }

        public void RemoveShapeWithStringName(string name)
        {
            if (name == null)
                return;
            for(int i = 0; i < _shapes.Count;i++)
            {
                if (_shapes[i].Name == name)
                    _shapes.RemoveAt(i--);
            }
        }
    }
}

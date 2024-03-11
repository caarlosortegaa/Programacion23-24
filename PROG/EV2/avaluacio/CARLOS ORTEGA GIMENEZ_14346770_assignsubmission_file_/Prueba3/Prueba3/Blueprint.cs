using Examen2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3
{
    public delegate bool FilterDelegate(IShape shape);
    public class Blueprint : IBlueprint
    {
        private List<IShape> _shapes = new List<IShape>();
        public void AddShape(IShape shape)
        {
            // Javi: TABUUUULAAA!!!!
            if (shape != null)

            _shapes.Add(shape);
        }

        public void draw(ICanvas canvas)
        {
            for(int i = 0; i < _shapes.Count; i++)
            {
                // Javi: Mal, es _shapes[i].Draw(canvas);
                canvas.DrawRectangle(_shapes[i].Rect);
            }
        }
        public List<IShape> GetShapes(FilterDelegate where)
        {
            List<IShape> shapes = new List<IShape>();
            for(int i = 0; i < _shapes.Count; i++)
            {
                // Javi: AAAHH!!! se te ha colao, es shapes.
                if (where(_shapes[i]))
                    _shapes.Add(_shapes[i]);
            }
            return _shapes;
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
                    _shapes.RemoveAt(i);
                // Javi: i--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
        }
    }
}

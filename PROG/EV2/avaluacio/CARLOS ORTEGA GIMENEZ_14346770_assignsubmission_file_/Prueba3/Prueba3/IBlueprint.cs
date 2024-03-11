using Examen2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3
{
    public interface IBlueprint
    {
        void AddShape(IShape shape);
        void RemoveShapeWithStringName(string name);
        IShape GetShapeWithName(string name);
        List<IShape> GetShapes(FilterDelegate del);
        // Javi: Minuscula
        void draw(ICanvas canvas);
    }
}

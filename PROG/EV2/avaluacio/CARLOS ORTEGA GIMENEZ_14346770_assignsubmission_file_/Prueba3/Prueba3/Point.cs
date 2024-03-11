using Examen2;


namespace Prueba3
{
    public class Point : Shape
    {
        public override void Draw(ICanvas canvas)
        {
            throw new NotImplementedException();
        }

        public override double GetArea()
        {
            return 0;
        }

        public override Point2D GetCenter()
        {
            return null;
        }

        public override double GetPerimeter()
        {

            return 0;               
        }

        public override Rect2D? GetRect2D()
        {
            throw new NotImplementedException();
        }

        public override bool HasArea()
        {
            return false;
        }
    }
}

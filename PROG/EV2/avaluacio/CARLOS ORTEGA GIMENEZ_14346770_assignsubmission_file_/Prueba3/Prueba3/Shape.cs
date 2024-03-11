using Examen2;

namespace Prueba3
{
    public abstract class Shape : IShape
    {
        protected string? name;
        private Color? color;
        public string? Name
        {
            get => name;
            set
            {
                name = value;
            }

        }
        // Javi: Tabula bien!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public Color Color { get => color; set 
            {
                color = value;
            } }
        public bool Hasarea { get => HasArea() ; }
        public double Area { get => GetArea(); }
        public double Perimeter { get => GetPerimeter(); }
        public Point2D? Center { get => GetCenter(); }
        // Javi: Mal
        public Rect2D? Rect { get; }

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract Rect2D? GetRect2D();
        public abstract Point2D GetCenter();
        public abstract bool HasArea();
        
        public Shape(string name,  Color? color)
        {
            this.name = name;
            this.color = color;
        }
        public Shape()
        {

        }
        

        public abstract void Draw(ICanvas canvas);
        public void SetName(string name)
        {
            if (name == null)
                return;
            Name = name;
        }

    }
}

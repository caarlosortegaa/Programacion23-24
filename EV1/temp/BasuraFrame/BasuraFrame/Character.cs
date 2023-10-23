
using UDK;

namespace BasuraFrame
{
    public class Character
    {
        public Rectangle rectangle = new Rectangle();
        public double r, g, b, a;
        public void Draw(ICanvas canvas)
        {
            canvas.FillShader.SetColor(r, g, b, a);
            canvas.DrawRectangle(rectangle.x, rectangle.y, rectangle.width,rectangle.height);
        }


    }
}

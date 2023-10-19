using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace BasuraFrame
{
    public class Character
    {
        public double x = 900;
        public double y = 498;

        public double r, g, b, a;
        public void Draw(ICanvas canvas)
        {
            canvas.FillShader.SetColor(r, g, b, a);
            canvas.DrawRectangle(x, y, 100, 100);
        }
    }
}

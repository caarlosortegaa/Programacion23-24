using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasuraFrame
{
    public class Rectangle
    {
        public double x;
        public double y;
        public double width = utils.GetRandomReal(100, 400);
        public double height = utils.GetRandomReal(100, 400);

        //public bool IsIntersecting(Rectangle r)
        //{
        //    if(x == r.x && y == r.y)
        //        return true;
        //}
    }
}

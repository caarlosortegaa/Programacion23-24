using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public enum ColorType
    {
        BLACK,
        GREY,
        BLUE
    }
    public class Dolphin
    {
        public double life;
        public double size;
        public string name;
        public ColorType type;

        public double GetLifePercent()
        {
            return life / 10;
        }
    }
}

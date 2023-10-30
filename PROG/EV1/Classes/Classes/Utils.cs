using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Utils
    {
        public static Random random = new Random();

        public static int GetRandom(int min, int max)
        {
            int dif = min - max + 1;
            return min + (random.Next() % dif);
        }
    }
}

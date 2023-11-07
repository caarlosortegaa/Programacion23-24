using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    public class Utils
    {
        private static Random _random = new Random();

        public static int GetRandom(int min, int max)
        {
            int dif = max - min + 1;
            return min + (_random.Next() % dif);
        }
        public static double GetRandomReal(double min, double max)
        {
            if (min > max)
            {
                double aux = min;
                min = max;
                max = aux;
            }
            return _random.NextDouble() * (max - min) + min;
        }
    }
}

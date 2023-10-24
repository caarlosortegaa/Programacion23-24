using System;

namespace BasuraFrame
{
    public class utils
    {
        public static Random _Random = new Random();
        public static double GetRandom()
        {
            return _Random.NextDouble();
        }
        public static double GetRandomReal(double min, double max)
        {
            if (min > max)
            {
                double aux = min;
                min = max;
                max = aux;
            }
            return _Random.NextDouble() * (max - min) + min;
        }
    }
}

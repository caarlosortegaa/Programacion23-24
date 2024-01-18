namespace Basura2ev
{
    public class EcuacionOutInRef
    {
        public static bool Ecuacion(out double x1, out double x2 ,double a,  double b, double c)
        {
            x1 = double.NaN;
            x2 = double.NaN;
            if (a == 0.0)
                return false;
            double aux = (b * b) - (4 * a * c);
            if(aux < 0)
                return false;
            double root = Math.Sqrt(aux);
            double denom = 1.0 / 2 * a;
            x1 = (-b + root) / (denom);
            x2 = (-b - root) / (denom);
            return true;
        }
    }
}

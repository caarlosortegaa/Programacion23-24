namespace Basura2ev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 45;
            double c = 3;
            double x1;
            double x2;

            EcuacionOutInRef.Ecuacion(out x1, out x2, a, b, c);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
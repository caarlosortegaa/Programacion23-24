namespace Basura3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<double> list = new List<double>();
            list.Add(1.0);
            list.Add(-5.5);
            list.Add(3.5);
            Basura3.GreaterThanZroCount(list);
            Console.WriteLine(Basura3.GreaterThanZeroCount(list));
        }
    }
}
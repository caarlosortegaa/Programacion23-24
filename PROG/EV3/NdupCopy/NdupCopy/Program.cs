namespace NdupCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var path in args)
            {
                Console.WriteLine(path);
            }
        }
    }
}
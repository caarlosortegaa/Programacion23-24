namespace Dolphin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolphin d1;
            d1 = new Dolphin();
            d1.name = "Juan";
            d1.LifeCapacity = 620;
            d1.SetLife(620);
            d1.GetLifePercent();
            d1.size = 5.0;
            d1.type = ColorType.BLACK;

            //double l;
            //l = d1.GetLifePercent();
            //Console.WriteLine(l);

            //d1.SetLife(-100.0);
            

        }
    }
}
namespace Dolphin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolphin d1;
            d1 = new Dolphin();

            d1.name = "Juan";
            d1.life = 270.0;
            d1.size = 5.0;
            d1.type = ColorType.BLACK;

            double l;
            l = d1.GetLifePercent();
           
        }
    }
}
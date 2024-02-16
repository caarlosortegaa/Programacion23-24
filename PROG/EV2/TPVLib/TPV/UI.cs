using TPVLib;
namespace TPV
{
    public class UI
    {
        public static void MainMenu(ITPV tpv)
        {
                Console.WriteLine("pulsa 0 Para salir");
                Console.WriteLine("pulsa 1 para el menu de prodcuctos");
        }
        
        public static int ReadOption()
        {
            var leer = Console.ReadLine();
            if (leer == "0")
                return 0;
            if(leer == "1")
                return 1;
            return 69;
        }
        public static void MenuProducts(ITPV tpv)
        {
                Console.WriteLine("Pulsa 0 para salir");
                Console.WriteLine("Pulsa 1 para añadir un producto");   
        }
    }
}

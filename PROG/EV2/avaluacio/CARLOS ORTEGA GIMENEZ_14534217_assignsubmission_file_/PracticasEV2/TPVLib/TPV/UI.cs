using TPVLib;
namespace TPV
{
    public class UI
    {
        public static void MainMenu()
        {
                Console.WriteLine("pulsa 0 Para salir");
                Console.WriteLine("pulsa 1 para el menu de prodcuctos");
        }
        
        
        public static void MenuProducts()
        {
                Console.WriteLine("Pulsa 0 para salir");
                Console.WriteLine("Pulsa 1 para añadir un producto");
                Console.WriteLine("Pulsa 2 Para eliminar un producto");
        }
        public static void MenuAddProduct()
        {
            Console.WriteLine("Añade el nombre del producto");
        }

        public static void MenuAddDescription()
        {
            Console.WriteLine("Describe como es tu producto");
        }

        public static void MenuAddPrice()
        {
            Console.WriteLine("Añade el precio del producto");
        }

        public static void MenuAddStock()
        {
            Console.WriteLine("Añade cuantos productos quedan");
        }
        public static void MenuRemoveProduct()
        {
            Console.WriteLine("Introduce el id que quieres borrar");
        }

    }
}

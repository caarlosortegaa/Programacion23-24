using TPVLib;
namespace TPV
{
    public class Controllers
    {
        public static void RunMainMenu(ITPV tpv)
        {
            bool IsRunning = true;
            while (IsRunning)
            {
                var options = UI.ReadOption();
                if (options == 0)            
                    IsRunning = false;
                if (options == 1)
                {
                    IsRunning = false;
                    Console.Clear();
                    UI.MenuProducts(tpv);
                }
            }

        }
    
        public static void RunProdcutsMenu(ITPV tpv, Product product)
        {
            bool IsRunning = true;
            while (IsRunning)
            {
                var option = UI.ReadOption();
                if (option == 0)
                {
                    IsRunning = false;
                    Console.Clear();
                    Console.WriteLine("Has Salido del menu de productos.");
                    UI.MainMenu(tpv);
                    Controllers.RunMainMenu(tpv);
                }
                    
                if (option == 1)
                {
                    tpv.AddProduct(product);
                    Console.Clear();
                    Console.WriteLine("Has añadido el producto correctamente");
                }
                if(option == 2)
                {
                    tpv.RemoveProductWithID(product.id);
                    Controllers.RunProdcutsMenu(tpv, product);
                }

            }
        }
    }

}


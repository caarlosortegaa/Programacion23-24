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
                UI.MainMenu();
                var options = UI.ReadOption();
                switch (options)
                {
                    case 0:
                        IsRunning = false;
                        break;
                    case 1:
                        UI.MenuProducts();
                        Controllers.RunMenuProducts(tpv);
                        break;
                }
            }
        }
        public static void RunMenuProducts(ITPV tpv)
        {
            bool IsRunning = true;
            while (IsRunning)
            {
                var options = UI.ReadOption();
                switch (options)
                {
                    case 0:
                        IsRunning = false;
                        break;
                    case 1:
                        Controllers.RunMenuAddProduct(tpv);
                        break;
                    case 2:
                        //Controllers.RunMenuRemoveProducts(tpv);
                        break;
                }
            }
        }

        private static Product RunMenuAddProduct(ITPV tpv)
        {
            Product product = new Product();
            UI.MenuAddProduct();
            product.Name = Console.ReadLine();
            UI.MenuAddDescription();
            product.Description = Console.ReadLine();
            UI.MenuAddPrice();
            product.Price = Convert.ToInt32(Console.ReadLine());
            UI.MenuAddStock();
            product.Stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Has añadido el producto");
            tpv.AddProduct(product);
            return product;
        }
        //private static Product? RunRemoveProductWithId(ITPV tpv)
        //{
            
        //}


    }
}


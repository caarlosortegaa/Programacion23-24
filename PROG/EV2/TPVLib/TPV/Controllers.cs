using System;
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
                
               switch(options)
               {
                    case 0: 
                        IsRunning = false;
                        break;
                    case 1:
                        UI.MenuProducts(tpv); 
                        Controllers.RunMainMenu(tpv);
                        break;
               }
            }

        }
    
        public static void RunProdcutsMenu(ITPV tpv)
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
                        UI.MenuAddProduct(tpv);

                        break;
                }    
            }
        }
        public static Product MenuAddProduct(ITPV tpv)
        {
            Product product = new Product();
            UI.MenuAddProduct(tpv);
            product.Name = Console.ReadLine();



            return product;
            
        }
    }

}


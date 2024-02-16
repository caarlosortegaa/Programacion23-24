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
                if (options == 0)
                    IsRunning = false;
                if (options == 1)
                    UI.MenuProducts(tpv);
            }

        }
    
        public void RunProdcutsMenu(ITPV tpv)
        {
            bool IsRunning = true;
            while (IsRunning)
            {
                var options = UI.ReadOption();
                if(options == 0)
                    IsRunning = false;
                if (options == 1)

                    
            }
        }
    }

}


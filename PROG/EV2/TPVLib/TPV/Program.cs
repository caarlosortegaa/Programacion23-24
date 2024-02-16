using TPVLib;
namespace TPV
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITPV tpv = new RAMTPV();
            Product product = new Product();
            product.Name = "Juan Francisco";
            UI.MainMenu(tpv);
            Controllers.RunMainMenu(tpv);
            Controllers.RunProdcutsMenu(tpv, product);
            
            
        }
    }
}
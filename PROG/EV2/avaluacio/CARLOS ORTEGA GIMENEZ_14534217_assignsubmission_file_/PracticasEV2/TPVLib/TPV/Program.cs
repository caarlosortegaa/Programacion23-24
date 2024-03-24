using TPVLib;
namespace TPV
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITPV tpv = new RAMTPV();
            Controllers.RunMainMenu(tpv);
        }
    }
}
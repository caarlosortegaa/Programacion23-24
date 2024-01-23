using DamLib;
using DAMLib;

namespace DAMLibTest
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            //Set<string> set = new Set<string>();
            //UnitTest.Test1(set);
            DAMLib.Dictionary<string, string> dic = new DAMLib.Dictionary<string, string>();
            dic.Add("juan", "fede");
            dic.Add("b", "j");
            dic.Add("t", "l");
            dic.Add("aua", "ueueu");
            dic.Remove("aua");
            //ItemSet<string> item = new ItemSet<string>();
            //item.Add("juan");
            //item.Add("kiki");
            //item.Add("fol");
            //item.Remove("fol");

        }
    }
}
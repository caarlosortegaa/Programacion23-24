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
            DAMLib.Dictionary<string, int> dic = new DAMLib.Dictionary<string, int>();
            dic.Add("juan", 2);
            dic.Add("b", 4);
            dic.Add("t", 6);
            dic.Add("aua", 8);
            //dic.Remove("aua");
            //ItemSet<string> item = new ItemSet<string>();
            //item.Add("juan");
            //item.Add("kiki");
            //item.Add("fol");
            //item.Remove("fol");
            var filter = dic.Filter((key, value) =>
            {
                return key.Contains("a");
            }
            );

        }
    }
}
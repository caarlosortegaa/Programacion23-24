using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basura3
{
    public class Basura3
    {
        

        public static int CountElements(List<string> list)
        {
            return list.Count;
        }

        public static void GreaterThanZroCount(List<double> List) // Funcion que te imprime los numeros que hay por encima de 0
        {
           
            for(int i = 0; i < List.Count; i++)
            {
                if (List[i] > 0)
                {
                    Console.WriteLine(List[i]);
                }
            }
        }
        public static int GreaterThanZeroCount(List<double> List) //Funcion que te cuenta cuantos numeros hay por encima de 0
        {
            int result = 0;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i] > 0)
                {
                    result++;
                }
            }
            return result;
        }


    }
}

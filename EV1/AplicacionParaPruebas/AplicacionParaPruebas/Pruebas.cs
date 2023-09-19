using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionParaPruebas
{
    public class Pruebas
    {
        public bool IsSecondParameterHigher(double n1, double n2)
        {
            return n1 < n2;
        }

        public bool IsEven(int  n1)
        {
            return n1 % 2 == 0;
        }

        public static int highterNumber(int n1, int n2, int n3)
        { 
            if (n2 >= n1 && n2 >= n3)
                return n2;
            if(n3 >= n1 && n3 >= n2)
                return n3;
            return n1;
            
        }
        public static int Sumatory(int n1)
        {
            int result = 0;
            for (int i = 0; i < n1; i++)
            {
                result += i;
            }
            return result;
            //    int result = 0;
            //    int i = 0;
            //    while (i <= n1)
            //    {
            //        result += i;
            //        i++;
            //    }
            //    return result;
        }

        public static void numbers(int num)
        {

            for (int i = 0; i < num/2; i++)
            {
                Console.WriteLine(i * 2);
  
            }
            return;
        }
   }
}

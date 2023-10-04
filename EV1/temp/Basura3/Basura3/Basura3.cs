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
        public static int CountElementsInt(List<int> list)
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

        public static bool IsInTheList(List<int> ListInt , int num)
        {
            if (ListInt == null)
                return false;
            for(int i = 0; i < ListInt.Count; i++)
            {
                if (ListInt[i] == num)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Funcion que devuelve el valor mayor de una lista de enteros
        /// </summary>
        /// <param name="IntList">Lista de enteros</param>
        /// <returns>Numero mas alto, si la lista es null devuelve int.MinValue</returns>
        public static int higherNumberInTheList(List<int> IntList)
        {
            if (IntList == null)
                return int.MinValue;

            int higherNumber = int.MinValue;
            for(int i = 0; i < IntList.Count; i++)
            {
                if (IntList[i] > higherNumber)
                    higherNumber = IntList[i];
            }
            return higherNumber;
        }

        public static int HighterNumberPositionInTheList(List<int> ListInt)
        {
            if (ListInt == null || ListInt.Count == 0)
                return -1;

            int Max= 0;
            int index = 0;
            for(var i = 0; i < ListInt.Count; i++)
            {
                if (ListInt[i] > Max)
                {
                    Max = ListInt[i];
                    index = i;
                }
            }
            return index;
        }
        public static bool IsInOrder(List<int> ListInt)
        {
            if (ListInt == null || ListInt.Count == 0)
                return false;
            int number = ListInt[0];
            for(int i = 1; i < ListInt.Count; i++)
            {
                if (ListInt[i] < number)
                    return false;
                number = ListInt[i];

            }
            return true;
        }

    }
}

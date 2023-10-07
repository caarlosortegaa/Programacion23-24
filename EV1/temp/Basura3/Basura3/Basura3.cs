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

            for (int i = 0; i < List.Count; i++)
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

        public static bool ContainList(List<int> ListInt, int num)
        {
            if (ListInt == null)
                return false;
            for (int i = 0; i < ListInt.Count; i++)
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
            for (int i = 0; i < IntList.Count; i++)
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

            int Max = 0;
            int index = 0;
            for (var i = 0; i < ListInt.Count; i++)
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
            int index = ListInt[0];
            for (int i = 1; i < ListInt.Count; i++)
            {
                if (ListInt[i] < index)
                    return false;
                index = ListInt[i];
            }
            return true;
        }

        public static bool BinarySearch(int[] array, int num)
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;

            while (min <= max)
            {
                mid = (max + min) / 2;

                if (array[mid] == num)
                    return true;
                if (num < array[mid])
                    max = mid - 1;
                else
                    min = mid + 1;

            }
            return false;
        }
        public static double Media(double[] array)
        {
            if (array == null || array.Length == 0)
                return double.NaN;
            double media = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                media = media + array[i];
            }
            return media / array.Length;
        }
        public static double Signature(double[] array, double threshold)
        {
            if (array == null || array.Length == 0)
                return double.NaN;
            double media = 0.0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= threshold)
                {
                    media += array[i];
                    count++;
                }
                if (count == 0)
                    return double.NaN;
            }
            return media / count;
        }
        public static int GetMaxCount(List<int> List)
        {
            if (List == null || List.Count == 0)
                return -1;
            int mayor = higherNumberInTheList(List);
            int count = 0;
            for (var i = 0; i < List.Count; i++)
            {
                if (mayor == List[i])
                    count++;
            }
            return count;
        }
        public static void ImprimirLista(List<int> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + ",");
            }
        }
    }
}

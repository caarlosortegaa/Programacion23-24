namespace Basura3
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<double> ListDouble = new List<double>();
            ListDouble.Add(1.0);
            ListDouble.Add(-5.5);
            ListDouble.Add(3.5);
            //Basura3.GreaterThanZroCount(ListDouble);
            //Console.WriteLine(Basura3.GreaterThanZeroCount(ListDouble));


            List<int> IntList = new List<int>();
            //for(int i = 0; i < 67; i++)
            //    IntList.Add(i);
            //Console.WriteLine(Basura3.ContainList(IntList, 67));

            IntList.Add(-10);
            IntList.Add(-9);
            IntList.Add(-8);
            IntList.Add(0);
            IntList.Add(1);
            IntList.Add(3);
            IntList.Add(3);
            IntList.Add(5);
            IntList.Add(6);

            //Console.WriteLine(Basura3.higherNumberInTheList(IntList));
            //Console.WriteLine(Basura3.HighterNumberPositionInTheList(IntList));
            //Console.WriteLine(Basura3.IsInOrder(IntList));
            //Console.WriteLine(Basura3.CountElementsInt(IntList));
            int[] array = new int[14];
            array[0] = 7;
            array[1] = 10;
            array[2] = 15;
            array[3] = 20;
            array[4] = 27;
            array[5] = 27;
            array[6] = 27;
            array[7] = 85;
            array[8] = 100;
            array[9] = 101;
            array[10] = 120;
            array[11] = 130;
            array[12] = 145;
            array[13] = 150;
            Console.WriteLine(Basura3.BinarySearch(array, 85));


        }
    }
}
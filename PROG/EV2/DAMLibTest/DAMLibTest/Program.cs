using DAMLib;

namespace DAMLibTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DAMLib.Stack<int> stack = new DAMLib.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
        }
    }
}
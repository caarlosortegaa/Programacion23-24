namespace Prueba4
{
    internal class Program
    {
        // Javi: NOTA 1
        static void Main(string[] args)
        {
            ExList<int> exList = new ExList<int> ();
            exList.AddElement (1);
            exList.AddElement (2);
            exList.AddElement (3);
            exList.AddElement (4);
            exList.AddElement (5);
            exList.AddElement (6);

            exList.Reverse();
        }
    }
}
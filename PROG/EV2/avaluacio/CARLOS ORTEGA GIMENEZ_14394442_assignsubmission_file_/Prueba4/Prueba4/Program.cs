namespace Prueba4
{
    internal class Program
    {
        // Javi: NOTA 1
        static void Main(string[] args)
        {
            ExList<string> exList = new ExList<string> ();
            exList.AddElement ("juan");
            exList.AddElement ("avelñi");
            exList.AddElement ("carlos");
            exList.AddElement ("adrian");
            exList.AddElement ("juanjko");
            exList.AddElement ("Fernaaando");
            exList.Insert(4, "aurelio");
            exList.Reverse();
        }
    }
}
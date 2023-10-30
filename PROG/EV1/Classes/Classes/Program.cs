namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CoffeeMachine c = new CoffeeMachine();
            //c.ChangeToNextState();
            Domino f = new Domino();
            f.SetValues(7, 9);
            Console.WriteLine(f.IsDouble());
        }
    }
}
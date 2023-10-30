namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CoffeeMachine c = new CoffeeMachine();
            //c.ChangeToNextState();
            DominoPiece f = DominoPiece.CreatePiece(6, 5);
            
            f?.GetValue1();
        }
    }
}
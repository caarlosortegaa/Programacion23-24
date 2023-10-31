namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card(Palo.CORAZONES, 5);
            Card c1 = new Card(Palo.TREBOLES, 11);
            List<Card> card = new List<Card>();
            card.Add(c1);
            card.Add(c);


            Console.WriteLine(UtilsCard.BlackJack(card));
        }
    }
}
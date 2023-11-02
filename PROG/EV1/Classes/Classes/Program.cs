namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card(Palo.CORAZONES, 1);
            Card c1 = new Card(Palo.CORAZONES, 11);
            Card c2 = new Card(Palo.TREBOLES, 0);
            List<Card> card = new List<Card>();
            card.Add(c);
            card.Add(c1);
            card.Add(c2);


            Console.WriteLine(UtilsCard.BlackJack(card));
        }
    }
}
namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card(Palo.CORAZONES, 12);
            Card c1 = new Card(Palo.CORAZONES, 3);
            Card c2 = new Card(Palo.TREBOLES, 1);
            List<Card> card = new List<Card>();
            card.Add(c);
            card.Add(c1);
            card.Add(c2);


            Console.WriteLine(UtilsCard.BlackJack(card));
        }
    }
}
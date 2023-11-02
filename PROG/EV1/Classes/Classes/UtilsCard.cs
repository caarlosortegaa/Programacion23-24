namespace Classes
{
    public class UtilsCard
    {
        public static int BlackJack(List<Card> cards)
        {
            int number = 0;
            for(int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Isvalid())
                {
                    if (cards[i].GetFigure() == FigureCardType.AS && number > 11)
                        number += 1;
                    else if (cards[i].GetFigure() == FigureCardType.AS && number < 11)
                        number += 11;
                    else if (cards[i].Isfigure() && cards[i].GetFigure() != FigureCardType.JOKER)
                        number += 10;
                    else
                        number += cards[i].Getnumber();
                }
                else
                    return -1;
            }
            return number;
        }
    }
}

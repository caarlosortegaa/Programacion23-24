using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class UtilsCard
    {
        public static int BlackJack(List<Card> card)
        {
            int number = 0;
            for(int i = 0; i < card.Count; i++)
            {
                if (card[i].Isvalid() == false)
                    return -1;
                if (card[i].GetFigure() == FigureType.AS && number > 11)
                    number += 1;
                else if (card[i].GetFigure() == FigureType.AS && number < 11)
                    number += 11;
                else if (card[i].Isfigure())
                    number += 10;
                else
                    number += card[i].Getnumber();
            }
            return number;
        }
    }
}

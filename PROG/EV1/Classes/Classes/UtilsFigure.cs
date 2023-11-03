

namespace Classes
{
    public class UtilsFigure
    {
        public static Chessfigure? GetFigureAt(List<Chessfigure> ListFigure , int x , int y, Chessfigure figure)
        {
            if(ListFigure == null || figure.IsValid() == false)
                return null;
            for(int i = 0; i < ListFigure.Count; i++)
            {
                if (ListFigure[i].GetX() == x && ListFigure[i].GetY() == y)
                    return ListFigure[i];
            }
            return null;
        }

    }
}

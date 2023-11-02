namespace Classes
{
    
    public class Chessfigure
    {
        int _x, _y;
        ColorType _color;
        FigureType _type;
        public Chessfigure(int x, int y, FigureType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        public enum ColorType
        {
            WHITE, BLACK
        }
        public enum FigureType
        {
            KNIGTH, PAWN, KING, TOWE, BISHOP, QUEEN
        }
        public bool IsValid()
        {

        }
        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }

        

    }
}

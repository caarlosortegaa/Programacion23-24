namespace Classes
{
    public enum FigureColorType
    {

    }
    public enum FigureChessType
    {
        
    }
    public class Chessfigure
    {
        int _x, _y;
        ColorType _color;
        FigureType _type;
        public enum ColorType
        {
            WHITE, BLACK
        }
        public enum FigureType
        {
            KNIGTH, PAWN, KING, TOWE, BISHOP, QUEEN
        }
        

    }
}

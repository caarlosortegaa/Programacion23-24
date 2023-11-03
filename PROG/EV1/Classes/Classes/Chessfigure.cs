namespace Classes
{
    
    public class Chessfigure
    {
        int _x, _y, movementCount;
        ColorType _color;
        FigureType _type;
       
        public Chessfigure(int x, int y, FigureType type , ColorType color)
        {
            _x = x;
            _y = y;
            _type = type;
            _color = color;
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
            if(_x < 0 || _y < 0 || _x > 8 || _y > 8)
                return false;
            return true;
        }
        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }
        public FigureType Getfigure()
        {
            return _type;
        }
        public int GetMovementCount()
        {
            return movementCount;
        }
        public bool HasBeenMoved()
        {
            return movementCount > 0;
        }

        public void moveTo(int x, int y)
        {
            
        }
        

    }
}

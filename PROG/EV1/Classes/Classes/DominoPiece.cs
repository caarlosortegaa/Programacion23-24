

namespace Classes
{
    public class DominoPiece
    {
        private int _value1;
        private int _value2;

        private DominoPiece(int value1, int value2)
        {            
            _value1 = value1;
            _value2 = value2;
        }
        public static DominoPiece? CreatePiece(int value1, int value2)
        {
            if (value1 > 6 || value1 < 0)
                return null;
            if (value2 > 6 || value2 < 0)
                return null;
            return new DominoPiece(value1, value2);
        }

        public int GetValue1()
        {
            return _value1;
        }
        public int GetValue2()
        {
            return _value2;
        }
        public int GetTotalValue()
        {
            return _value1 + _value2;
        }
        public bool IsDouble()
        {
            if (_value1 == _value2)
                return true;
            return false;
        }
    }
}

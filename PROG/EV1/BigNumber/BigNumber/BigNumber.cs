
namespace BigNumber
{
    public  class BigNumber
    {
        private List<int> _ListInt = new List<int>();
        public BigNumber()
        {
        }
        

        public void Set(long longs)
        {
            int n = (int)longs;
            while ((n % 10) > 0)
            {
                _ListInt.Add(n);
                n = n / 10;
            }
            for (int i = 0; i <= _ListInt.Count / 2; i++)
            {
                int num = _ListInt.Count - 1 - i;
                int aux = _ListInt[i];
                _ListInt[i] = num;
                num = aux;
            }
        }
        public void Set(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                _ListInt.Add(s[i]);
            }
        }
        public string ToString()
        {
            string result = "";
            for(int i = 0; i < _ListInt.Count; i++)
            {
                result = result + _ListInt[i] ;
            }
            return result;
        }
        public int GetDigitCount()
        {
            return _ListInt.Count;
        }
        public int GetDigitAt(int index)
        {
            return _ListInt[index];
        }
        public BigNumber clone()
        {
            return new BigNumber();
        }
        public static BigNumber Add(BigNumber big1, BigNumber big2)
        {
            return big1;
        }
        public static BigNumber sub(BigNumber b1, BigNumber b2)
        {
            return b2;
        }
    }
}

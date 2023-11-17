

using System.Security.Cryptography.X509Certificates;

namespace BigNumber
{
    public  class BigNumber
    {
        private List<int> _ListInt = new List<int>();
        public BigNumber(long longs)
        {
            int u = (int)longs;
            while(u > 10)
            {
                _ListInt.Add(u % 10);
                u = u / 10;
            }
        }
        public BigNumber(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                _ListInt.Add(s[i]);
            }
        }

        public void Set(long n1)
        {

        }
        public void Set(string s)
        {

        }
        public string ToString()
        {
            return "";
        }
        public int GetDigitCount()
        {
            return _ListInt.Count;
        }
        public int GetDigitAt(int index)
        {
            return 0;
        }
        public BigNumber clone()
        {
            return new BigNumber("");
        }
        public static BigNumber Add(BigNumber big1, BigNumber big2)
        {
            return big1;
        }
        public static BigNumber b2(BigNumber b1, BigNumber b2)
        {
            return b2;
        }
    }
}

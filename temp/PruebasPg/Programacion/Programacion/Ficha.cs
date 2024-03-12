namespace Programacion
{
    public class Ficha
    {
        private int _num1 { get; }
        private int _num2 { get; }

        public bool IsDouble => _num1 == _num2;
        
        public Ficha(int num1, int num2) 
        {
            if (num1 <= 6 && num1 >= 0 && num2 <= 6 && num2 >= 0)
            {
                _num1 = num1;
                _num2 = num2;
            }
        }
    }
}

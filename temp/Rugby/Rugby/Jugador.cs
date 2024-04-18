namespace Rugby
{
    public abstract class Jugador : Personaje
    {
        private int _x;
        private int _y;
        public Jugador(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}

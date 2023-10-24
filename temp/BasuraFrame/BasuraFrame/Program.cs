using OpenTK.Windowing.Common.Input;
using UDK;

namespace BasuraFrame
{
    public class Program
    {
        static void Main(string[] args)
        {
           MiJuego juego = new MiJuego();
            UDK.Game.Launch(juego);
        }
    }
}
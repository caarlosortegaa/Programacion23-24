using UDK;

namespace BasuraFrame
{
    internal class Program
    {
        public class MiJuego : UDK.IGameDelegate
        {
            public void OnAnimate(GameDelegateEvent gameEvent)
            {
                
            }

            public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
            {
                canvas.Clear(0, 0, 0, 1);
                canvas.Camera.SetRectangle(0, 0, canvas.Width, canvas.Height);

                canvas.FillShader.SetColor(1,1,0,1);
                canvas.DrawRectangle(0, 0, 200, 200);
            }

            public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
            {
                
            }

            public void OnLoad(GameDelegateEvent gameEvent)
            {
                
            }

            public void OnUnload(GameDelegateEvent gameEvent)
            {
                
            }
        }
        static void Main(string[] args)
        {
           MiJuego juego = new MiJuego();
            UDK.Game.Launch(juego);
        }
    }
}
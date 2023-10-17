using UDK;

namespace BasuraFrame
{
    internal class Program
    {
        public class Character
        {
            public double x = 0.0;
            public double y = 0.0;

            public double r, g, b, a;
        }
        public class MiJuego : UDK.IGameDelegate
        {

           List<Character> jugadores = new List<Character>();
            public void OnLoad(GameDelegateEvent gameEvent)
            {
                Character pj1 = new Character();
                pj1.r = 1.0;
                pj1.g = 1.0;
                pj1.b = 1.0;
                pj1.a = 1.0;
                Character pj2 = new Character();
                pj2.r = 0.0;
                pj2.g = 1.0;
                pj2.b = 1.0;
                pj2.a = 1.0;
                Character pj3 = new Character();
                pj3.r = 1.0;
                pj3.g = 1.0;
                pj3.b = 0.0;
                pj3.a = 1.0;
                jugadores.Add(pj1);
                jugadores.Add(pj2);
                jugadores.Add(pj3);
            }

            public void OnAnimate(GameDelegateEvent gameEvent)
            {
                for (int i = 0; i < jugadores.Count; i++)
                {
                    jugadores[i].x += utils.GetRandomReal(-1, 1);
                    jugadores[i].y += utils.GetRandomReal(-2, 2);
                }
            }

            public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
            {
                canvas.Clear(0.0, 0.0, 0.0, 1.0);
                canvas.Camera.SetRectangle(0, 0, canvas.Width, canvas.Height);

                for(int i = 0; i < jugadores.Count; i++)
                {
                    canvas.FillShader.SetColor(jugadores[i].r, jugadores[i].g, jugadores[i].b, jugadores[i].a);
                    canvas.DrawRectangle(jugadores[i].x, jugadores[i].y, 190, 190);
                    
                }
                
            }

            public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
            {
                for (int i = 0; i < jugadores.Count; i++)
                {
                    if (keyboard.IsKeyDown(Keys.Right))
                        jugadores[i].x += 3.5f;
                    if (keyboard.IsKeyDown(Keys.Left))
                        jugadores[i].x -= 3.5f;
                    if (keyboard.IsKeyDown(Keys.Up))
                        jugadores[i].y += 3.5f;
                    if (keyboard.IsKeyDown(Keys.Down))
                        jugadores[i].y -= 3.5f;
                }

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
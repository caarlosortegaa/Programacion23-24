using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace BasuraFrame
{
    public class MiJuego : UDK.IGameDelegate
    {
        List<Character> jugadores = new List<Character>();
        Character pj1 = new Character();
        Character pj2 = new Character();
        Character pj3 = new Character();

        public void OnLoad(GameDelegateEvent gameEvent)
        {
            CreateCharacter();
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
            for (int i = 0; i < jugadores.Count; i++)
            {
                Character ch = jugadores[i];
                ch.Draw(canvas);
            }
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {

        }
        public void CreateCharacter()
        {
            for (int i = 0; i < 1000; i++)
            {
                Character j = new Character();
                j.r = utils.GetRandom();
                j.g = utils.GetRandom();
                j.b = utils.GetRandom();
                j.a = utils.GetRandom();
                jugadores.Add(j);
            }
        }
    }
}

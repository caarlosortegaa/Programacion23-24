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
        Mundo? Mundo;
       
        public void OnLoad(GameDelegateEvent gameEvent)
        {
            Mundo = new Mundo();
            Mundo.CreateCharacter();
        }
        public void OnKeyboard(GameDelegateEvent gameEvent, IKeyboard keyboard, IMouse mouse)
        {
            
                if (keyboard.IsKeyDown(Keys.Right))
                    Mundo.GetCharacterAt(0).x += 3.5f;
                if (keyboard.IsKeyDown(Keys.Left))
                    Mundo.GetCharacterAt(0).x -= 3.5f;
                if (keyboard.IsKeyDown(Keys.Up))
                    Mundo.GetCharacterAt(0).y += 3.5f;
                if (keyboard.IsKeyDown(Keys.Down))
                    Mundo.GetCharacterAt(0).y -= 3.5f;
            

        }
        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            for (int i = 0; i < Mundo.GetCharacterCount(); i++)
            {
                Mundo.GetCharacterAt(i).x += utils.GetRandomReal(-1, 1);
                Mundo.GetCharacterAt(i).y += utils.GetRandomReal(-2, 2);
            }
        }

        public void OnDraw(GameDelegateEvent gameEvent, ICanvas canvas)
        {

            Mundo.DrawWorld(canvas);
        }

        public void OnUnload(GameDelegateEvent gameEvent)
        {

        }
       
    }
}

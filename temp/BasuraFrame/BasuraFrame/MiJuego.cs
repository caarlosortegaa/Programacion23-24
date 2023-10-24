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
                    Mundo.GetCharacterAt(0).rectangle.x += 3.5f;
                if (keyboard.IsKeyDown(Keys.Left))
                    Mundo.GetCharacterAt(0).rectangle.x -= 3.5f;
                if (keyboard.IsKeyDown(Keys.Up))
                    Mundo.GetCharacterAt(0).rectangle.y += 3.5f;
                if (keyboard.IsKeyDown(Keys.Down))
                    Mundo.GetCharacterAt(0).rectangle.y -= 3.5f;
            

        }
        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            for (int i = 0; i < Mundo.GetCharacterCount(); i++)
            {
                Mundo.GetCharacterAt(i).rectangle.x += utils.GetRandomReal(-0.5, 0.5);
                Mundo.GetCharacterAt(i).rectangle.y += utils.GetRandomReal(-0.5, 0.5);
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


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
                    Mundo.GetCharacterAt(0).rectangle.x += 1.0f;   
                if (keyboard.IsKeyDown(Keys.Left))
                    Mundo.GetCharacterAt(0).rectangle.x -= 1.0f;
                if (keyboard.IsKeyDown(Keys.Up))
                    Mundo.GetCharacterAt(0).rectangle.y += 1.0f;
                if (keyboard.IsKeyDown(Keys.Down))
                    Mundo.GetCharacterAt(0).rectangle.y -= 1.0f;
                if(keyboard.IsKeyDown(Keys.Escape))
                gameEvent.window.Close();
                
            

        }
        public void OnAnimate(GameDelegateEvent gameEvent)
        {
            for (int i = 0; i < Mundo.GetCharacterCount(); i++)
            {
                Mundo.GetCharacterAt(i).rectangle.x += utils.GetRandomReal(0, 0);
                Mundo.GetCharacterAt(i).rectangle.y += utils.GetRandomReal(0, 0);
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

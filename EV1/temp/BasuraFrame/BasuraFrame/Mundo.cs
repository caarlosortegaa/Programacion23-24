using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UDK;

namespace BasuraFrame
{
    public class Mundo
    {
       private List<Character> _jugadores = new List<Character>();
        public int GetCharacterCount()
        { 
            return _jugadores.Count; 
        }
        public Character? GetCharacterAt(int index)
        {
            if(index < 0 || index >= _jugadores.Count)
                return null;
            return _jugadores[index];
        }
        public void CreateCharacter()
        {
            
            for (int i = 0; i < 200; i++)
            {
                Character j = new Character();
                j.r = utils.GetRandom();
                j.g = utils.GetRandom();
                j.b = utils.GetRandom();
                j.a = utils.GetRandom();
                _jugadores.Add(j);
            }
        }

        public void DrawWorld(ICanvas canvas)
        {
            canvas.Clear(0.0, 0.0, 0.0, 1.0);
            canvas.Camera.SetRectangle(0, 0, canvas.Width, canvas.Height);
            for (int i = 0; i < _jugadores.Count; i++)
            {
                Character ch = _jugadores[i];
                ch.Draw(canvas);
            }
        }
    }
}

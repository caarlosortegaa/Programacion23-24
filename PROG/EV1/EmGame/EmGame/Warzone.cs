using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    public class Warzone
    {
        int _width;
        int _height;
        private List<Warrior> Warriors = new List<Warrior>();
        public Warzone(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void CreateWarriors(int count, TeamType type)
        {

        }
        public void RemoveAt(int index)
        {

        }
    }
}

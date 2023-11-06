using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    public enum TeamType
    {
        HUMAN,DWARF,ORC,ELF
    }
    public class Warrior
    {
        int _x, _y, _life, _armor;
        double _accuracity;
        TeamType TeamType;
        public Warrior(int x, int y, int life, int armor, double accuracity, TeamType teamType)
        {
            _x = x;
            _y = y;
            _life = life;
            _armor = armor;
            _accuracity = accuracity;
            TeamType = teamType;
        }
    }
}



namespace EmGame
{
    public enum TeamType
    {
        HUMAN = 0,DWARF = 1,ORC = 2,ELF = 3 
    }
    public class Warrior
    {
        int _x, _y, _life = 100, _armor;
        double _accuracity;
        TeamType _TeamType;
        List<Weapon> _weapons = new List<Weapon>();
        public Warrior(int x, int y, int life, int armor, double accuracity, TeamType teamType)
        {
            _x = x;
            _y = y;
            _life = life;
            _armor = armor;
            _accuracity = accuracity;
            _TeamType = teamType;
        }
        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }
        public int GetLife()
        {
            return _life;
        }
        public int GetArmor()
        {
            return _armor;
        }
        public double GetAccuracity()
        {
            return _accuracity;
        }
        public TeamType GetTeamType()
        {
            return _TeamType;
        }



    }
}

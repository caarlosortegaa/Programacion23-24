

using System.Net.NetworkInformation;

namespace EmGame
{
    public class Warzone
    {
        int _width;
        int _height;
        private List<Warrior> _Warriors = new List<Warrior>();
        public Warzone(int width, int height)
        {   
            _width = width;
            _height = height;
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetHeigth()
        {
            return _height;
        }

        public void CreateWarriors(int count, TeamType type)
        {
           
            for(int i = 0; i < count; i++)
            {
                Warrior w = new Warrior(Utils.GetRandom(0,_width) , Utils.GetRandom(0, _height), 100, Utils.GetRandom(0, 6),  Utils.GetRandomReal(0, 10.0), type);
                _Warriors.Add(w);
            }
        }
        public void RemoveAt(int index)
        {
            if(index < 0 || index >= _Warriors.Count)
                return;
            _Warriors.RemoveAt(index);
        }
        public Warrior? GetWarriorAt(int index)
        {
            if (index < 0)
                return null;
            return _Warriors[index];
        }
        public Warrior? GetWarrior(int x , int y)
        {
            for(int i = 0; i < _Warriors.Count;i++)
            {
                if (GetWarriorAt(i).GetX() == x && GetWarriorAt(i).GetY() == y)
                    return _Warriors[i];
            }
            return null;
        }
        public int GetWarriorCount()
        {
            return _Warriors.Count;
        }

        
        public int GetEnemiesArroundCount(int x , int y, TeamType type)
        {
            int count = 0;  
            for(int i = (x - 1); i <= (x + 1);i++)
            {
                for (int j = (y - 1); j <= (y + 1);j++)
                {
                    if(GetWarrior(i , j) != null && GetWarrior(i , j).GetTeamType() != type && i != x && j != y)
                        count++;
                }
            }
            return count;
        }
        public int GetWarriorArroundCount(int x , int y)
        {
            int count = 0;  
            for(var i = (x - 1); i <= (x + 1);i++)
            {
                for(var j = (y - 1); j <= (y + 1);j++)
                {
                    if (GetWarrior(i, j) != null && i != x && j != y)
                        count++;
                    
                }
            }
            return count;
        }
        public List<Warrior> GetWarriorArround(int x, int y)
        {
            List<Warrior> List = new List<Warrior>();
            for (int i = (x - 1); i <= (x + 1); i++)
            {
                for (int j = (y - 1); j <= (y + 1); i++)
                {
                    if (GetWarrior(i, j) != null)
                        List.Add(GetWarrior(i, j));
                }
            }
            return List;
        }

        public static double GetDistance(double x, double y, double x2 , double y2)
        {
            return  Math.Sqrt((x2 - x) * 2 + (y2 - 2) * 2);
        }
        
    }
}

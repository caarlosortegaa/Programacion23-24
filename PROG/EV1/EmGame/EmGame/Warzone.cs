

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
                Warrior w = new Warrior(Utils.GetRandom(0,10) , Utils.GetRandom(0, 10), 100, Utils.GetRandom(0, 6),  Utils.GetRandomReal(0, 10.0), type);
                _Warriors.Add(w);
            }
        }
        public Warrior GetWarriorAt()
        {

        }
        public void RemoveAt(int index)
        {
            _Warriors.RemoveAt(index);
        }
    }
}

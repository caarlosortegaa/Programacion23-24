

namespace Dolphin
{
    public enum ColorType
    {
        BLACK,
        GREY,
        BLUE
    }
    public class Dolphin
    {
        public double life;
        public double LifeCapacity;
        public double size;
        public string? name;
        public ColorType type;

        public double GetLifePercent()
        {
            return life / LifeCapacity * 100;
        }

        public double Getlife()
        {
            return life;
        }

        public void SetLife(double value)
        {
           if(value < 0 || value > LifeCapacity)
                throw new ArgumentOutOfRangeException("value");
               life = value;
            
        }
    }
}

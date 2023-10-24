

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
        private double _Life;
        public double LifeCapacity;
        public double size;
        public string? name;
        public ColorType type;

        public double GetLifePercent()
        {
            return _Life / LifeCapacity * 100;
        }

        public double Getlife()
        {
            return _Life;
        }

        public void SetLife(double value)
        {
           if(value < 0 || value > LifeCapacity)
                throw new ArgumentOutOfRangeException("value");
               _Life = value;
        }
    }
}

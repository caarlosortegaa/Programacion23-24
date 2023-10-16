
namespace Dolphin
{
    public enum Charactertype
    {
        POLICE, THIEF
    }
    public class Character
    {
        public string? name;
        public Charactertype type;
        public double x = 0.0;
        public double y = 0.0;
        public double size = 1.0;
        public double velocity = 1.0;

    }
}

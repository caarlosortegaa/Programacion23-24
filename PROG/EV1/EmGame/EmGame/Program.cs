namespace EmGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warzone wz = new Warzone(10, 10);
            wz.CreateWarriors(5, TeamType.HUMAN);
            wz.CreateWarriors(5, TeamType.DWARF);
            wz.CreateWarriors(5, TeamType.ORC);
            wz.CreateWarriors(5, TeamType.ELF);
        }
    }
}
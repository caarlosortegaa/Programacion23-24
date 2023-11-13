namespace EmGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warzone wz = new Warzone(10, 10);
            wz.CreateWarriors(20, TeamType.HUMAN);
            wz.CreateWarriors(20, TeamType.DWARF);
            wz.CreateWarriors(20, TeamType.ORC);
            wz.CreateWarriors(20, TeamType.ELF);

            Console.WriteLine(wz.GetEnemiesArroundCount(4, 7, TeamType.DWARF));
            Console.WriteLine(wz.GetWarriorArroundCount(4, 7));
            Console.WriteLine(Warzone.GetDistance(2, 7, 5, 8));
        }
    }
}
namespace Dolphin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dolphin d1;
            //d1 = new Dolphin();
            //d1.name = "Juan";
            //d1.LifeCapacity = 620;
            //d1.SetLife(620);
            //d1.GetLifePercent();
            //d1.size = 5.0;
            //d1.type = ColorType.BLACK;
            Character c = new Character();
            c.name = "juan";
            c.type = Charactertype.POLICE;
            Character c2 = new Character();
            c2 = c;
            Character c3 = new Character();
            c3.name = "Juan Federico";
            c3.type = Charactertype.THIEF;
            List<Character> list = new List<Character>();
            list.Add(c);
            list.Add(c3);
            Console.WriteLine(CharacterUtils.ContainsDuplicado(list));
            //Console.WriteLine(CharacterUtils.Contains(list, "federico"));



            //double l;
            //l = d1.GetLifePercent();
            //Console.WriteLine(l);

            //d1.SetLife(-100.0);
            

        }
    }
}
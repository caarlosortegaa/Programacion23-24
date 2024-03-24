namespace DAMLib
{
    public class UnitTest
    {
        public bool IsEmptyJuanito { get; set; }
        public int CountJuanito { get; set; }
        public bool ContainsJuanito { get; set; }
        public bool IsEmptyFer { get; set; }
        public int CountFer{ get; set; }
        public bool ContainsFer { get; set; }

        public static UnitTest Test1(Set<string> set)
        {
            UnitTest test = new UnitTest();
            {
                set.clear();
                set.Add("juanito");
                test.IsEmptyJuanito = set.IsEmpty;
                test.CountJuanito = set.Count;
                test.ContainsJuanito = set.Contains("juanito");

                set.Add(null);

                set.Add("Fer");
                test.IsEmptyFer = set.IsEmpty;
                test.CountFer = set.Count;
                test.ContainsFer = set.Contains(null);




                

            }
            return test;
        }
    }
}

namespace Rugby
{
    public class utils
    {
        private static Random _Random = new Random();
       
        public static int GetRandomInt(int min, int max)
        {
            if(min > max)
            {
                int aux = min;
                min = max;
                max = aux;
            }
            return _Random.Next(min, max);
        }
    }
}

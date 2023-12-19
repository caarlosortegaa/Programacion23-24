namespace basura33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rect2D rect = new Rect2D();
            Rect2D rect1 = new Rect2D();
            Point2D point = new Point2D(5, 9);
            Point2D point2 = new Point2D(3 , 7);
            rect.SetMin(point);
            rect.SetMax(point2);
            rect.GetArea();
            Console.WriteLine(rect);
        }
    }
}
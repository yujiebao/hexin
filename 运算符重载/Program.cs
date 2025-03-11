namespace 运算符重载
{
    class Point
    {
        public int x;
        public int y;
        public static Point operator + (Point a, Point b)
        {
            Point p = new Point();
            p.x = a.x + b.x;
            p.y = a.y + b.y;
            return p;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        Point ()
        {
            x = 0;
            y = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1,3);
            Point b = new Point(2,6);
            Point c = a + b;
            Console.WriteLine("{0},{1}", c.x, c.y);
        }
    }
}
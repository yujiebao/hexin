namespace 拓展方法
{
    public static class Tool
    {
        public static void Print(this string str)
        {
         Console.WriteLine("这是拓展方法");
        }

        public static string ToLower(this string str)
        {
            Console.WriteLine("你好");
            return null;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string s = "SACSd";
            s.Print();
            string a = s.ToLower();
            Console.WriteLine(a);
        }
    }
}
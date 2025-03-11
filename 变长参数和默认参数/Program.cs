namespace 变长参数和默认参数
{
    
    internal class Program
    {
        // 可变参数
        static void add( params int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        // 默认参数
        static void print(string a = "hello",string b = "world")
        {
            Console.WriteLine(a + " " + b);
        }
        static void Main(string[] args)
        {
            //add(1, 2, 3, 4, 5);
            print();
            print( "a","b");
        }
    }
}
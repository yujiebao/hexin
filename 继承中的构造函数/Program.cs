namespace 继承中的构造函数
{
    
    public class Father
    {
        int a;
        int b;
        public Father()
        {
            Console.WriteLine("Father   无参");
        }
        public Father(int a, int b)
        {
            Console.WriteLine("Father 两个参数");
            this.a = a;
            this.b = b;
        }
        public Father(int a)
        {
            Console.WriteLine("Father  一个参数");
            this.a = a;
        }

    }

    public class Son : Father
    {
        public Son()
        {
            Console.WriteLine("Son 无参");
        }
        public Son(int a, int b) : base(a, b)
        {
            Console.WriteLine("Son 两个参");
        }
        public Son(int a) : base(a)
        {
            Console.WriteLine("Son  一个参数");
            
        }
    }
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Father pepole = new Son(1);
        }   
       

    }
}
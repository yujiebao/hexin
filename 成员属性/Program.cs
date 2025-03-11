namespace 成员属性
{
    internal class Program
    {
        private  string _Name;
        // 注意
        //1.默认不加 会使用属性申明时的访问权限
        //2.加的访问修饰符要低于属性的访问权限
        //3.不能让get和set的访问权限都低于属性的权限
        public string Name 
        { //属性中可以添加逻辑和加密
            private get
            { 
                return _Name; 
            }
            
             set
            {
                _Name = value;
            } 
        }


        static void Main(string[] args)
        {
 
            Console.WriteLine("Hello, World!");
        }
    }
}
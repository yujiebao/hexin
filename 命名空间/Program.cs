using aa;
#region 命名空间的基本概念
//概念： 用来组织和重用代码的
//作用:就像一个工具包,类就是一件一件的工具,都是申明在命名空间里面的
#endregion

#region 命名空间的使用
/*namespace 命名空间名 
{
    类
    类
}*/
//可以写多个命名空间
//命名空间可以写同名的
#endregion

#region 不同命名空间中相互使用,需要引用命名空间或者指明出处
//using 命名空间名    
//命名空间.类名
#endregion

#region 不同命名空间中允许有同名的类
//但要在同一命名空间中使用不同命名空间中的同名的类时，需要指明出处
#endregion

#region 命名空间可以包裹命名空间
/*namespace bb
{
    public class People
    {
        public int a;
        public int age;
    }
    namespace cc
    {

    }
}*/
//工具包里又有 工具包  命名空间.包裹的命名空间.类
#endregion


#region q其他
//命名空间的访问修饰符
//public   默认值
//private    会报错
//internal   只能在当前工程的程序集使用
#endregion
namespace aa
{
    public class People
    {
        public int a;
        public int age;
    }
}
namespace 命名空间
{
    using aa;
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("Hello, World!");
        }
    }
}
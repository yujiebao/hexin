namespace 密封方法
{
    #region 密封方法的概念
    //用密封关键字sealed 修饰的重写函数
    //作用:让虚方法或者抽象方法之后不能再被重写
    //特点:和override一起出现
    #endregion

    #region 知识点二 实例
    public abstract class Animal
    {
         public abstract void Eat();
        public virtual void speak()
        {
            Console.WriteLine("Animal Speak");
        }
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog Eat");
        }

        public sealed override void speak()
        {
            Console.WriteLine("Dog Speak");
        }
    }

    public class WhiteDog:Dog
    {
      /*  public override void speak()   不能重写  父类中是密封的
        {
            Console.WriteLine("WhiteDog Speak");
        }*/
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
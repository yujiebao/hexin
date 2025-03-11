namespace 抽象类和接口的区别
{
    #region 知识点一 抽象类
    /*1.概念：被抽象关键字abstract修饰的类
    特点：
        1.不能被实例化
        2.可以包含抽象方法
        3.继承抽象类必须重写抽象方法*/
    abstract class Animal
    {
        public abstract void Eat();
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("狗吃骨头");
        }
    }
    #endregion

    #region 知识点二 抽象方法
    //又叫 纯虚方法
    //用 abstract关键字修饰的方法
    //特点:
    //1.只能在抽象类中申明
    //2.没有方法体
    //3.不能是私有的    要能够被子类重写---可以是public 和 protected
    //4.继承后必须实现 用override重写
    #endregion

    #region 抽象方法和虚方法
    //虚方法 ：父类和
    /*核心区别总结
    对比维度     虚方法                        抽象方法
    实现要求     必须有默认实现                 不能有实现
    类类型限制   普通类或抽象类均可定义          必须定义在抽象类中
    子类强制要求 子类可自由选择是否重写          子类必须重写（除非子类也是抽象类）
    设计意图     提供扩展点，支持选择性覆盖      强制实现接口，定义行为规范*/

    #endregion

    #region 总结
    //抽象类 被abstract修饰的类 不能被实例化 可以包含抽象方法
    //抽象方法，没有方法体的纯虚方法 继承后必须去实现的方法
    //注意:
    //如何选择普通类还是抽象类
    //不希望被实例化的对象，相对比较抽象的类可以使用抽象类
    //父类中的行为不太需要被实现的，只希望子类去定义具体的规则的 可以选择 抽象类然后使用其中的抽象方法来定义规则
    //作用：
    //整体框架设计
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog(); //抽象类不能被实例化 但可以使用里氏替换原则 父类容器装子类
            Console.WriteLine("Hello, World!");
        }
    }
}
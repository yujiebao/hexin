namespace 多态vob
{
    #region 知识点一 多态的概念
    // 多态按字面的意思就是“多种状态”
    // 让继承同一父类的子类们 在执行相同方法时有不同的表现(状态）
    // 主要目的
    // 同一父类的对象 执行相同行为(方法)有不同的表现
    //解决的问题
    //让同一个对象有唯一行为的特征
    #endregion

    #region 知识点二 解决的问题 
    //多种行为
    #endregion

    #region 知识点三 多态的实现
    //编译时的多态  函数重载

    //运行时多态 vob
    //虚函数   virtual
    //重写 override 
    //父类（基类）base
    #endregion
 
    public class Father
    {
        
        public virtual void Show()
        {
            Console.WriteLine("我是一个父亲");
        }

       
    }

    public class Son:Father
    {
        public override  void Show()
        { 

            Console.WriteLine("我是一个儿子");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             Father father = new Son();
            father.Show();
            (father as Son).Show();  // 不使用虚函数和重写---两种行为   使用虚函数和重写  --一种行为
        }
    }
}
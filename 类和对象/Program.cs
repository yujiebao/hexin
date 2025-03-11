namespace 类和对象
{
     class on
    {
        public int age;
        public string name;
        public on(int a)
        {
            age = 18;
        }
        public on(string n,int a):this(a)
        {
            name = "小明";
        }
    }
    internal class Program
    {
         
        
        static void Main(string[] args)
        {
        #region 知识点一 什么是类Class
        //具有相同的特征   具有相同行为 的一类事物的抽象 
        //类是对象的模版 可以通过类来创建出对象
        #endregion

        #region 知识点二 类声明在哪里
        //一般在namespace(非内部类)
        #endregion

        #region 知识点五 什么是(类)对象
        //基本概念
        // 类的申明 和 类对象(变量)申明是两个概念
        //类的申明 类似 枚举 和 结构体的申明 。类的申明相当于申明了一个自定义变量类型
        //而对象 是类创建出来的
        //相当于申明一个指定类的变量
        //类创建对象的过程 一般称为实例化对象
        //类对象 都是引用类型的
        #endregion
    }
    }
}
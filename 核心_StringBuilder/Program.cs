using System.Text;
namespace 核心_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点 StringBuilder
            //C#提供的一个用于处理字符串的公共类
            //主要解决的问题是:
            //修改字符串而不创建新的对象,需要频繁修改和拼接的字符串可以使用它，可以提升性能   --减少GC
            //使用前 需要引用命名空间
            #endregion

            #region 初始化  直接指明内容
            StringBuilder str = new StringBuilder("113165161");
            #endregion

            #region 容量
            //stringBuilder存在一个容量的问题，每次往里面增加时 会自动扩容  
            //获得容量
            Console.WriteLine(str.Capacity);
            //获得字符长度
            Console.WriteLine(str.Length);
            #endregion

            #region 增删查改
            //拼接
            str.Append("123456789");
            Console.WriteLine(str);
            
            //插入
            str.Insert(3,"123456789");

            //删除
            str.Remove(3,5);

            //清空
            str.Clear();

            //查找
            //Console.WriteLine(str[0]);

            //改
            str[0] = 'a';  //StringBuilder的索引器是可读可写的  string的索引器只能读

            //替换
            str.Replace("123456789","123456789");

            //重新赋值
            str.Clear();
            str.Append("sdasd");

            //判断相等
            Console.WriteLine(str.Equals("sdasd"));
            #endregion
        }
    }
}
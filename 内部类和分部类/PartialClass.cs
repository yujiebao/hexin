using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 内部类和分部类
{
    public partial class PartialClass
    {
        public int a;
        public void test1()
        {
            Console.WriteLine("test1");
        }
        partial void Speak();
       
    }
    
    public partial class PartialClass
    {
        public int b;
        public void test2()
        {
            Console.WriteLine("test2");
        }
        partial void Speak()
        {
            Console.WriteLine("Speak");
        }
    }
}

namespace 继承
{
    public class Teacher
    {
        public string name;
        public int age;
        public int number;
        public Teacher()
        {
            Console.WriteLine("heloo");
        }
        public Teacher(string name, int age, int number)
        {
            this.name = name;
            this.age = age;
            this.number = number;
            Console.WriteLine("{0}的年龄是：{1} 工号:{2}", name, age, number);
        }
        public void test()
        {
            Console.WriteLine("heloo");
        }
    }
    public class TeachingTeacher:Teacher
    {
        public string subject;

        public TeachingTeacher(string name, int age, int number) : base(name, age, number)
        {

        }

        public TeachingTeacher():base() { }

    }
    public class ChineseTeacher : TeachingTeacher
    {
        public void testc()
        {
            Console.WriteLine("一行白鹭上青天");
        }
       
    }
    internal class Program
    {
         
        static void Main(string[] args)
        {
            TeachingTeacher teachingTeacher = new TeachingTeacher();
            TeachingTeacher teachingTeacher1 = new TeachingTeacher("aa",5,6);
            ChineseTeacher chineseTeacher = new ChineseTeacher();
            chineseTeacher.testc();
        }
    }
}
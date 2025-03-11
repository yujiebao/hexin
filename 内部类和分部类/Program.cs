namespace 内部类和分部类
{
    internal class Program
    {
        public class People
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Body body;
            public class Body
            {
                  Arm LeftArm;
                  Arm RightArm;
                 public class Arm
                {
                    public int Id { get; set; }
                    public string Name { get; set; }
                }
            }
        }
        static void Main(string[] args)
        {
            People people = new People();
            People.Body body= new People.Body();
            people.body = body;
            People.Body.Arm arm = new People.Body.Arm();

            PartialClass partialClass = new PartialClass();
            partialClass.test1();
            partialClass.test2();
        }
    }
}
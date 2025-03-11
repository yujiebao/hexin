namespace 里氏替换原则
{
    public class Gameobject
    {
    }
    public class Player : Gameobject
    {
        public void test()
        {
            Console.WriteLine("这是玩家");
        }
    }


    public class Boss: Gameobject
    {
        public void test()
        {
            Console.WriteLine("这是boss");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Gameobject[] gameobjects = { new Player(),new Player(),new Boss()};
            for(int i = 0;i<gameobjects.Length;i++)
            {
                if (gameobjects[i] is Player)
                {

                    (gameobjects[i] as Player).test();
                }
                else if (gameobjects[i] is Boss)
                {

                    (gameobjects[i] as Boss).test();
                }

            }
            Console.WriteLine("Hello, World!");
        }
    }
}
namespace HelloName
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            SayHello(name);
        }

        static void SayHello(string name) 
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}

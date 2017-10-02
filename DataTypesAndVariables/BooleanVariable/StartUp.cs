namespace BooleanVariable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            bool result = Convert.ToBoolean(input);
            if (result) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}

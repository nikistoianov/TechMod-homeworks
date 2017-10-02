namespace VariableInHexadecimalFormat
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(input, 16));
        }
    }
}

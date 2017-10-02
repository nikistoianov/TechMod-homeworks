namespace ExchangeVariableValues
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Before:{0}a = {1}{0}b = {2}", Environment.NewLine, a, b);

            int tempVal = a;
            a = b;
            b = tempVal;
            Console.WriteLine("After:{0}a = {1}{0}b = {2}", Environment.NewLine, a, b);

        }
    }
}

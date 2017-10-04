namespace FibonacciNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n)); 
        }

        static long Fib(int n)
        {
            long lastNumber = 1, previousNumber = 0, result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = previousNumber + lastNumber;
                previousNumber = lastNumber;
                lastNumber = result;
            }
            return result;
        }
    }
}

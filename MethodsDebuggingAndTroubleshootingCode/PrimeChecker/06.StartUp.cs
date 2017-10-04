namespace PrimeChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n)); 
        }

        static bool IsPrime(long n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

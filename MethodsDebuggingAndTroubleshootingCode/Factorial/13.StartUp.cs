namespace Factorial
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcFactorial(num));
        }

        static BigInteger CalcFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
//READY
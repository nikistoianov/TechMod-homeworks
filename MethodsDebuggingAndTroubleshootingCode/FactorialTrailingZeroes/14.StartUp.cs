namespace FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = CalcFactorial(num);
            Console.WriteLine(CountTrailingZeroes(factorial));
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

        static int CountTrailingZeroes(BigInteger num) 
        {
            int counter = 0;
            while (num > 0)
            {
                if (num % 10 == 0)
                {
                    counter++;
                }
                else
                {
                    return counter;
                }
                num /= 10;
            }
            return counter;
        }

    }
}
//READY
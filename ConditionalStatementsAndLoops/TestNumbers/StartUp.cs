
namespace TestNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int totalSum = 0, count = 0;

            for (int n = first; n >= 1; n--)
            {
                for (int m = 1; m <= second; m++)
                {
                    totalSum += 3 * n * m;
                    count += 1;
                    if (totalSum >= max)
                    {
                        Console.WriteLine("{0} combinations", count);
                        Console.WriteLine("Sum: {0} >= {1}", totalSum, max);
                        return;
                    }
                }
            }

            Console.WriteLine("{0} combinations", count);
            Console.WriteLine("Sum: {0}", totalSum);
        }
    }
}

namespace GameOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magical = int.Parse(Console.ReadLine());

            int firstFound = 0, secondFound = 0, count = 0;
            bool matchFound = false;

            for (int n = first; n <= second; n++)
            {
                for (int m = first; m <= second; m++)
                {
                    count += 1;
                    if (n + m == magical)
                    {
                        firstFound = n;
                        secondFound = m;
                        matchFound = true;
                    }
                }
            }

            if (matchFound)
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", firstFound, secondFound, magical);
            }
            else
            {
                Console.WriteLine("{0} combinations - neither equals {1}", count, magical);
            }
        }
    }
}

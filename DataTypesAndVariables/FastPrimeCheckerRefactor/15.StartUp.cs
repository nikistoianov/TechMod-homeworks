namespace FastPrimeCheckerRefactor
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int maxRange = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= maxRange; currentNumber++)
            {   
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(currentNumber); divisor++)
                {
                    if (currentNumber % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", currentNumber, isPrime);
            }

        }
    }
}
// READY


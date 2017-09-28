namespace IntervalOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = Math.Min(firstNum, secondNum); i <= Math.Max(firstNum, secondNum); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

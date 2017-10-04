namespace EnglishNameOfTheLastDigit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int lastDigit = (int)Math.Abs(number % 10);

            Console.WriteLine(DigitName(lastDigit));
        }

        static string DigitName(int digit)
        {
            switch (digit)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "zero";
            }
        }
    }
}

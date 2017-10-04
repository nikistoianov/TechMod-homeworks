namespace NumbersInReversedOrder
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            decimal input = decimal.Parse(Console.ReadLine());
            string inputString = input.ToString();
            ReverseStrings(inputString);
        }

        static void ReverseStrings(string inputString)
        {
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.Write(inputString[i]);
            }
        }
    }
}

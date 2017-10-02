namespace IntegerToHexAndBinary
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            //Console.WriteLine(number.ToString("X"));
            Console.WriteLine(string.Format("{0:x}", number));
        }
    }
}

namespace IntegerToHexAndBinary
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            //Console.WriteLine(number.ToString("X"));
            Console.WriteLine(string.Format("{0:X}", number));
            Console.WriteLine(Convert.ToString(number, 2));

        }
    }
}
// READY
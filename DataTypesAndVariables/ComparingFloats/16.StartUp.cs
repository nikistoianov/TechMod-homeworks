namespace ComparingFloats
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double difference = Math.Abs(firstNumber - secondNumber);
            Console.WriteLine((difference < 0.000001));
        }
    }
}
// READY
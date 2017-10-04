namespace CenterPoint
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long X1 = long.Parse(Console.ReadLine());
            long Y1 = long.Parse(Console.ReadLine());
            long X2 = long.Parse(Console.ReadLine());
            long Y2 = long.Parse(Console.ReadLine());

            double firstDistance = GetDistanceToZero(X1, Y1); Console.WriteLine(firstDistance);
            double secondDistance = GetDistanceToZero(X2, Y2); Console.WriteLine(secondDistance);

            if (firstDistance <= secondDistance)
            {
                Console.WriteLine("({0}, {1})", X1, Y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", X2, Y2);
            }
        }

        static double GetDistanceToZero(long X, long Y)
        {
            return Math.Sqrt(X * X + Y * Y);            
        }
    }
}

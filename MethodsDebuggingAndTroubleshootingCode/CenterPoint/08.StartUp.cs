namespace CenterPoint
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            double firstDistance = GetDistanceToZero(X1, Y1);// Console.WriteLine(firstDistance);
            double secondDistance = GetDistanceToZero(X2, Y2);// Console.WriteLine(secondDistance);

            if (firstDistance <= secondDistance)
            {
                Console.WriteLine("({0}, {1})", X1, Y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", X2, Y2);
            }
        }

        static double GetDistanceToZero(double X, double Y)
        {
            return Math.Sqrt(X * X + Y * Y);            
        }
    }
}

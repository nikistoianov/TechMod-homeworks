namespace LongerLine
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
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());

            double firstDistance = GetDistance(X1, Y1, X2, Y2);
            double secondDistance = GetDistance(X3, Y3, X4, Y4);

            if (firstDistance >= secondDistance)
            {
                if (GetDistance(X1, Y1, 0, 0) <= GetDistance(X2, Y2, 0, 0))
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", X1, Y1, X2, Y2); 
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", X2, Y2, X1, Y1);
                }                
            }
            else
            {
                if (GetDistance(X3, Y3, 0, 0) <= GetDistance(X4, Y4, 0, 0))
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", X3, Y3, X4, Y4);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", X4, Y4, X3, Y3);
                }
            }
        }

        static double GetDistance(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
        }
    }
}

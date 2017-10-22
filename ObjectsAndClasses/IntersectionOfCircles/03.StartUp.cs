using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircles
{
    class Program
    {
        static void Main()
        {
            double[] arr1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] arr2 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Circle circle1 = new Circle() {CenterX = arr1[0], CenterY = arr1[1], Radius = arr1[2]};
            Circle circle2 = new Circle() {CenterX = arr2[0], CenterY = arr2[1], Radius = arr2[2]};
            Console.WriteLine(IntersectCircles(circle1, circle2) ? "Yes" : "No");
        }

        static bool IntersectCircles(Circle circle1, Circle circle2)
        {
            double dist = GetDistance(circle1.CenterX, circle1.CenterY, circle2.CenterX, circle2.CenterY);
            return dist <= circle1.Radius + circle2.Radius;
        }

        static double GetDistance(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
        }
    }

    public class Circle
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double Radius { get; set; }
    }
}

namespace GeometryCalculator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string figure = Console.ReadLine();
            double firstParam = double.Parse(Console.ReadLine());
            double secondParam = 0;
            if (figure == "triangle" || figure == "rectangle")
            {
                secondParam = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0:F2}", AreaCalculator(figure, firstParam, secondParam));
        }

        static double AreaCalculator(string figure, double firstParam, double secondParam) 
        {
            if (figure == "triangle")
            {
                return firstParam * secondParam / 2;
            }
            else if (figure == "square")
            {
                return firstParam * firstParam;
            }
            else if (figure == "rectangle")
            {
                return firstParam * secondParam;
            }
            else if (figure == "circle")
            {
                return Math.PI * firstParam * firstParam;
            }
            else
            {
                return 0;
            }
        }

    }
}

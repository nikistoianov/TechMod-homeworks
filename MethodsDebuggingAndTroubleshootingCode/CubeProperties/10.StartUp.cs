namespace CubeProperties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            switch (parameter)
            {
                case "face":
                    Console.WriteLine("{0:F2}", CubeFaceDiagonal(side));
                    break;
                case "space":
                    Console.WriteLine("{0:F2}", CubeSpaceDiagonal(side));
                    break;
                case "volume":
                    Console.WriteLine("{0:F2}", CubeVolume(side));
                    break;
                case "area":
                    Console.WriteLine("{0:F2}", CubeArea(side));
                    break;
                default:
                    break;
            }
        }

        static double CubeArea(double side)
        {
            return 6 * side * side;
        }

        static double CubeVolume(double side)
        {
            return side * side * side;
        }

        static double CubeSpaceDiagonal(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        static double CubeFaceDiagonal(double side)
        {
            return Math.Sqrt(2 * side * side);
        }

    }
}

namespace TriangleOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string line = "";
                for (int j = 0; j < i; j++)
                {
                    line += i.ToString() + " ";
                }
                Console.WriteLine(line);
            }
        }
    }
}

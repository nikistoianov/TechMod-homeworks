using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "a aaaa";
            string[] arr = input.Split();
            long sum = 0;

            for (int i = 0; i < Math.Max(arr[0].Length, arr[1].Length); i++)
            {
                int num1 = (i < arr[0].Length) ? (int)arr[0][i] : 1;
                int num2 = (i < arr[1].Length) ? (int)arr[1][i] : 1;
                sum += num1 * num2;
            }
            Console.WriteLine(sum);
        }
    }
}

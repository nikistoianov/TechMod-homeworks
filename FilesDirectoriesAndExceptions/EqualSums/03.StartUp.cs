using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main()
        {
            string[] inputLines = File.ReadAllLines(@"..\..\input.txt");
            File.WriteAllText(@"..\..\output.txt", "");
            foreach (var line in inputLines)
            {
                string result = CalcEqualSums(line);
                Console.WriteLine(result);
                File.AppendAllText(@"..\..\output.txt", result + Environment.NewLine);
            }  
        }

        private static string CalcEqualSums(string line)
        {
            int[] arr = line.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                long leftSum = CalcLeftSum(arr, i - 1);
                long rightSum = CalcRightSum(arr, i + 1);
                if (leftSum == rightSum)
                {
                    return i.ToString();
                }
            }
            return "no";
        }

        private static long CalcRightSum(int[] arr, int fromIndex)
        {
            var result = arr.Skip(fromIndex).ToArray().Sum();
            return result;
        }

        private static long CalcLeftSum(int[] arr, int toIndex)
        {
            var result = arr.Take(toIndex + 1).ToArray().Sum();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main()
        {
            string[] inputLines = File.ReadAllLines(@"..\..\input.txt");
            File.WriteAllText(@"..\..\output.txt","");
            foreach (var line in inputLines)
            {
                int result = CalcMostFrequentNumber(line);
                Console.WriteLine(result);
                File.AppendAllText(@"..\..\output.txt", result.ToString() + Environment.NewLine);
            }            
        }

        private static int CalcMostFrequentNumber(string line)
        {
            int[] arr = line.Split().Select(int.Parse).ToArray();
            var nums = arr.Distinct().ToDictionary(x => x, y => 0);
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                nums[arr[i]]++;
                counter = Math.Max(counter, nums[arr[i]]);
            }

            int result = nums.Where(x => x.Value == counter).ToArray()[0].Key;
            return result;            
        }
    }
}

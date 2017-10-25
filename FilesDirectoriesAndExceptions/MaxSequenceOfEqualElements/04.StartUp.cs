using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            string[] inputLines = File.ReadAllLines(@"..\..\input.txt");
            File.WriteAllText(@"..\..\output.txt", "");
            foreach (var line in inputLines)
            {
                string result = GetMaxSequenceOfEqualElements(line);
                Console.WriteLine(result);
                File.AppendAllText(@"..\..\output.txt", result + Environment.NewLine);
            }
        }

        private static string GetMaxSequenceOfEqualElements(string line)
        {
            int[] arr = line.Split(' ').Select(int.Parse).ToArray();
            int bestStart = 0, bestLen = 1, start = 0, len = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    len++;
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                    start = i;
                    len = 1;
                }
            }

            if (len > bestLen)
            {
                bestLen = len;
                bestStart = start;
            }

            var result = arr.Skip(bestStart).Take(bestLen).ToArray();
            return string.Join(" ", result);            
        }
    }
}

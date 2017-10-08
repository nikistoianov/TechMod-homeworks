using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numbers = new List<int>();
            var counts = new List<int>();
            int maxCount = 1;

            foreach (int item in arr)
            {
                int id = numbers.IndexOf(item);
                if (id > -1)
                {
                    counts[id]++;
                    maxCount = Math.Max(maxCount, counts[id]);
                }
                else
                {
                    numbers.Add(item);
                    counts.Add(1);
                }
            }

            int closerLeft = counts.IndexOf(maxCount);
            Console.WriteLine(numbers[closerLeft]);
        }
    }
}

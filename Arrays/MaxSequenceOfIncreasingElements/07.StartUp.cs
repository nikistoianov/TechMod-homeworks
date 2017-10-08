using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main()
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int bestStart = 0, bestLen = 1, start = 0, len = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
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

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                long leftSum = CalcLeftSum(arr, i - 1);
                long rightSum = CalcRightSum(arr, i + 1);
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");

        }

        private static long CalcRightSum(int[] arr, int fromIndex)
        {
            long sum = 0;
            for (int i = fromIndex; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        private static long CalcLeftSum(int[] arr, int toIndex)
        {
            long sum = 0;
            for (int i = 0; i <= toIndex; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}

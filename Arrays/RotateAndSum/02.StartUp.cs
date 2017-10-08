using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sum = new int[arr.Length];
           
            for (int i = 0; i < k; i++)
            {
                RotateAndAppend(arr, sum);
            }
            Console.WriteLine(string.Join(" ", sum));
            
        }

        private static void RotateAndAppend(int[] arr, int[] sum)
        {
            int oldInt = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
                sum[i] += arr[i];
            }
            arr[0] = oldInt;
            sum[0] += arr[0];

        }
    }
}

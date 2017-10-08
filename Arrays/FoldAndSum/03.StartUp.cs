using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstArr = new int[arr.Length / 2];
            int[] secondArr = new int[arr.Length / 2];
            int[] sum = new int[arr.Length / 2];

            for (int i = 0; i < arr.Length / 4; i++)
            {
                firstArr[i] = arr[arr.Length / 4 - i - 1];
                firstArr[firstArr.Length - 1 - i] = arr[3 * arr.Length / 4 + i];
            }
            for (int i = 0; i < firstArr.Length; i++)
            {
                secondArr[i] = arr[i + arr.Length / 4];
                sum[i] = firstArr[i] + secondArr[i];
            }
            //Console.WriteLine(string.Join(" ", firstArr));
            //Console.WriteLine(string.Join(" ", secondArr));
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}

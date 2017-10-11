using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            nums.RemoveRange(arr[0], nums.Count - arr[0]);
            nums.RemoveRange(0, arr[1]);
            bool numExists = nums.Contains(arr[2]);

            if (numExists)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}

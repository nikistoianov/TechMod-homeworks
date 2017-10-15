using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> result = GetLIS(arr);
            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> GetLIS(int[] arr)
        {
            List<List<int>> nums = new List<List<int>>();

            int maxLenght = 1;

            foreach (int item in arr)
            {
                int loopEnd = nums.Count;
                bool itemAdded = false;
                for (int i = 0; i < loopEnd; i++)
                {
                    int lastNum = nums[i].Count - 1;
                    if (nums[i][lastNum++] < item)
                    {
                        nums.Add(new List<int>(nums[i].ToArray()));
                        nums[nums.Count - 1].Add(item);
                        itemAdded = true;
                        maxLenght = Math.Max(maxLenght, lastNum + 1);
                    }
                }
                if (!itemAdded)
                {
                    nums.Add(new List<int> { item });
                }
            }
            
            foreach (List<int> singleNums in nums)
            {
                if (singleNums.Count == maxLenght)
                {
                    return singleNums;
                }
            }
            return new List<int>();
        }
    }
}

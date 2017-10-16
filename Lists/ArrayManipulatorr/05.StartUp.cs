using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulatorr
{
    class Program
    {
        static void Main()
        {
            List<long> nums = Console.ReadLine().Split().Select(long.Parse).ToList();
            string commandLine = Console.ReadLine();

            while (commandLine != "print")
            {
                string[] arr = commandLine.Split();
                switch (arr[0])
                {
                    case "add":
                        nums.Insert(int.Parse(arr[1]), long.Parse(arr[2]));
                        break;
                    case "addMany":
                        //List<int> elements = new List<int>(arr);
                        long[] elements = new long[arr.Length - 2];
                        for (int i = 2; i < arr.Length; i++)
                        {
                            elements[i - 2] = long.Parse((arr[i]));
                        }
                        nums.InsertRange(int.Parse(arr[1]), elements);
                        break;
                    case "contains":
                        int id = nums.IndexOf(long.Parse(arr[1]));
                        Console.WriteLine(id);
                        break;
                    case "remove":
                        nums.RemoveAt(int.Parse(arr[1]));
                        break;
                    case "shift":
                        ShiftListLeft(nums, int.Parse(arr[1]));
                        break;
                    case "sumPairs":
                        SumPairs(ref nums);
                        break;

                }
                commandLine = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

        private static void SumPairs(ref List<long> nums)
        {
            List<long> newNums = new List<long>();
            for (int i = 0; i < nums.Count; i+=2)
            {
                if (i == nums.Count - 1)
                {
                    newNums.Add(nums[i]);
                }
                else
                {
                    newNums.Add(nums[i] + nums[i + 1]);
                }
            }
            nums = newNums;
        }

        private static void ShiftListLeft(List<long> nums, int positions)
        {
            while (positions > nums.Count)
            {
                positions -= nums.Count;
            }
            
            List<long> firstNums = new List<long>(nums);
            firstNums.RemoveRange(positions, firstNums.Count - positions);
            nums.RemoveRange(0, positions);
            nums.AddRange(firstNums);
        }
    }
}

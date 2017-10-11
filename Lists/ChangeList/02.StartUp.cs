using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commandLine = Console.ReadLine();

            while (commandLine != "Odd" && commandLine != "Even")
            {                
                string[] arr = commandLine.Split();

                if (arr[0] == "Delete")
                {
                    RemoveElements(nums, int.Parse(arr[1]));
                }
                else if (arr[0] == "Insert")
                {
                    nums.Insert(int.Parse(arr[2]), int.Parse(arr[1]));
                }
                commandLine = Console.ReadLine();
            }

            if (commandLine == "Odd")
            {
                RemoveElements(nums, true);
            }
            else if (commandLine == "Even")
            {
                RemoveElements(nums, false);
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        private static void RemoveElements(List<int> nums, bool evenElements)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if ((nums[i] % 2 == 0 && evenElements) || (nums[i] % 2 != 0 && !evenElements))
                {
                    nums.RemoveAt(i--);
                }
            }
        }

        private static void RemoveElements(List<int> nums, int valToRemove)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == valToRemove)
                {
                    nums.RemoveAt(i--);
                }
            }
        }
    }
}

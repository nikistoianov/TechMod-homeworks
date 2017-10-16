using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main()
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            string[] arr = Console.ReadLine().Split();
            double bombNumber = double.Parse(arr[0]);
            int power = int.Parse(arr[1]);

            bool listDetonated = true;

            while (listDetonated)
            {
                listDetonated = DetonateList(nums, bombNumber, power);
            }

            double sum = SumListElements(nums);
            Console.WriteLine(sum);
        }

        static double SumListElements(List<double> nums)
        {
            double sum = 0;
            foreach (double num in nums)
            {
                sum += num;
            }
            return sum;
        }

        static bool DetonateList(List<double> nums, double bombNumber, int power)
        {
            int foundID = nums.IndexOf(bombNumber);
            if (foundID == -1)
            {
                return false;
            }
            else
            {
                int removeFrom = Math.Max(0, foundID - power);
                int removeTo = Math.Min(nums.Count - 1, foundID + power);
                nums.RemoveRange(removeFrom, removeTo - removeFrom + 1);
                return true;
            }
            
        }
    }
}

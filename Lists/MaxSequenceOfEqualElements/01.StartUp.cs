using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bestIndex = 0, bestLenght = 1, lenght = 1, index = 0;

            for (int i = 1; i < nums.Count; i++)
            {
                bool isEqual = (nums[i] == nums[i - 1]);

                if (isEqual)
                {
                    lenght++;
                }

                if (!isEqual || i == nums.Count - 1)
                {
                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        bestIndex = index;
                    }
                    lenght = 1;
                    index = i;
                }
                
            }

            for (int i = bestIndex; i < bestIndex + bestLenght; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }

        

    }
}

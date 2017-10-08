using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');

            int startMatch = FindCommonStart(firstArr, secondArr);
            int endMatch = FindCommonStart(firstArr.Reverse().ToArray(), secondArr.Reverse().ToArray());
            Console.WriteLine(Math.Max(startMatch, endMatch));

        }
        
        static int FindCommonStart(string[] firstArr, string[] secondArr)
        {
            int min = Math.Min(firstArr.Length, secondArr.Length);
            for (int i = 0; i < min; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    return i;
                }
            }
            return min;
        }

    }
}

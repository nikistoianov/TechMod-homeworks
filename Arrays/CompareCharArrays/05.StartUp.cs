using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            bool switchArrays = false, foundDiff = false;

            int min = Math.Min(firstArr.Length, secondArr.Length);
            for (int i = 0; i < min; i++)
            {
                if (firstArr[i] > secondArr[i])
                {
                    switchArrays = true;
                    break;
                }
                else if (firstArr[i] < secondArr[i])
                {
                    foundDiff = true;
                    break;
                }
            }

            if (!switchArrays && !foundDiff && (firstArr.Length > secondArr.Length))
            {
                switchArrays = true;
            }

            if (switchArrays)
            {
                Console.WriteLine(string.Join("", secondArr));
                Console.WriteLine(string.Join("", firstArr));
            }
            else
            {
                Console.WriteLine(string.Join("", firstArr));
                Console.WriteLine(string.Join("", secondArr));
            }
        }
    }
}

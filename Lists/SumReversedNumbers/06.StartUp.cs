using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main()
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double sum = 0;
            foreach (double number in arr)
            {
                double reversedNumber = ReverseDigits(number);
                sum += reversedNumber;
                //Console.WriteLine(reversedNumber);
            }
            Console.WriteLine(sum);
        }

        static double ReverseDigits(double number)
        {
            string inputString = number.ToString();
            inputString = ReverseStrings(inputString);
            return double.Parse(inputString);
        }

        static string ReverseStrings(string inputString)
        {
            string result = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                result += inputString[i];
            }
            return result;
        }
    }
}

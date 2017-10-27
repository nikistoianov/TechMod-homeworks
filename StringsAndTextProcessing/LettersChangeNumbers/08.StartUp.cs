using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "z2147483647z z2147483647z z2147483647z z2147483647z z2147483647z z2147483647z z2147483647z z2147483647z z2147483647z z2147483647z";
            double sum = 0;
            string[] arr = input.Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in arr)
            {
                double stringVal = CalcStringVal(item);
                sum += stringVal;
            }
            Console.WriteLine($"{sum:F2}");
        }

        private static double CalcStringVal(string text)
        {            
            char firstChar = text[0], lastChar = text[text.Length - 1];            
            int firstIndex, lastIndex;
            string middle = text.Substring(1, text.Length - 2);
            int number = int.Parse(middle);
            double result = (double)number;

            //divide if uppercase
            if (firstChar > 64 && firstChar < 91)
            {
                firstIndex = firstChar - 64;
                result /= firstIndex;
            }
            else if (firstChar > 96 && firstChar < 123)
            {
                firstIndex = firstChar - 96;
                result *= firstIndex;
            }
            else
            {
                return 0;
            }

            //subtract if uppercase
            if (lastChar > 64 && lastChar < 91)
            {
                lastIndex = lastChar - 64;
                result -= lastIndex;
            }
            else if (lastChar > 96 && lastChar < 123)
            {
                lastIndex = lastChar - 96;
                result += lastIndex;
            }

            return result;
        }
    }
}

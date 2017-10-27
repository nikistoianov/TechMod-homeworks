using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main()
        {
            //BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            //BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            //var result = firstNum + secondNum;
            //Console.WriteLine(result);

            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            string result = SumBigNumbers(firstNum, secondNum);
            Console.WriteLine(result);
        }

        private static string SumBigNumbers(string firstNum, string secondNum)
        {
            firstNum = ReverseString(firstNum);
            secondNum = ReverseString(secondNum);
            string result = "";
            int waitingDigit = 0;
            for (int i = 0; i < Math.Max(firstNum.Length, secondNum.Length); i++)
            {
                int firstDigit = i < firstNum.Length ? (firstNum[i] - 48) : 0;
                int secondDigit = i < secondNum.Length ? (secondNum[i] - 48) : 0;
                int sum = waitingDigit + firstDigit + secondDigit;
                int addDigit = sum % 10;
                result = addDigit + result;
                waitingDigit = (sum - addDigit) / 10;
            }
            if (waitingDigit > 0)
            {
                result = waitingDigit + result;
            }
            return result.TrimStart('0');
        }

        private static string ReverseString(string text)
        {
            char[] charArr = text.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(MultiplyBigNumbers("9999", 9));
            string firstNum = Console.ReadLine();
            byte secondNum = byte.Parse(Console.ReadLine());
            string result = MultiplyBigNumbers(firstNum, secondNum);
            Console.WriteLine(result);
        }

        private static string MultiplyBigNumbers(string firstNum, byte secondNum)
        {
            if (secondNum == 0)
            {
                return "0";
            }
            firstNum = ReverseString(firstNum);
            string result = "";
            int waitingDigit = 0;
            for (int i = 0; i < firstNum.Length; i++)
            {
                int firstDigit = firstNum[i] - 48;
                //int secondDigit = i < secondNum.Length ? (secondNum[i] - 48) : 0;
                int multiply = waitingDigit + firstDigit * secondNum;
                int addDigit = multiply % 10;
                result = addDigit + result;
                waitingDigit = multiply / 10;
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

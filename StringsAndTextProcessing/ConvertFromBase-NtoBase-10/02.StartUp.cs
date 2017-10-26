using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_NtoBase_10
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "3 1234567890";

            string[] arr = input.Split();
            BigInteger result = ConvertBaseNToBase10(arr[1], byte.Parse(arr[0]));
            Console.WriteLine(result);
        }

        private static BigInteger ConvertBaseNToBase10(string numString, byte n)
        {
            BigInteger result = 0;
            int power = 0;
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                int digit = numString[i] - 48;
                //Console.WriteLine(digit * Math.Pow(n, power));
                //Console.WriteLine($"{digit} x {n}^{power}");
                var current = digit * BigInteger.Pow(n, power);
                //double current = digit * Math.Pow(n, power);
                result += (BigInteger)current;
                power++;
            }
            return result;
        }
    }
}

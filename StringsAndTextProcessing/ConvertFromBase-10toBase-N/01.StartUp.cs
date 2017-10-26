using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_10toBase_N
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "4 10000000001000000000100000000010000000001";

            string[] arr = input.Split();
            string result = ConvertBase10ToBaseN(BigInteger.Parse(arr[1]), byte.Parse(arr[0]));
            Console.WriteLine(result);
        }

        private static string ConvertBase10ToBaseN(BigInteger number, byte n)
        {
            string result = "";
            var balance = number;
            while (true)
            {
                BigInteger digit;
                balance = BigInteger.DivRem(balance, n, out digit);
                //string digit = (balance % n).ToString();
                //balance = Math.Floor(balance / n);                
                result = digit + result;
                if (balance == 0)
                {
                    return result;
                }
                else if (balance < n)
                {
                    return balance.ToString() + result;
                }
            }
        }
    }
}

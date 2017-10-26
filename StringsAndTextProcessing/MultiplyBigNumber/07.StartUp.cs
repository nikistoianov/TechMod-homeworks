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
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            byte secondNum = byte.Parse(Console.ReadLine());
            var result = firstNum * secondNum;
            Console.WriteLine(result);
        }
    }
}

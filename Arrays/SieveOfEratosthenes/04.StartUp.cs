using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = Enumerable.Repeat(true, n + 1).ToArray();
           
            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                    int j = i * 2;
                    while (j <= n)
                    {
                        primes[j] = false;
                        j += i;
                    }
                }
            }
        }
    }
}

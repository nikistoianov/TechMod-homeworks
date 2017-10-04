namespace PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            long startNum = long.Parse(Console.ReadLine());
            long endNum = long.Parse(Console.ReadLine());

            string prefix = "";
            foreach (long foundPrime in FindPrimesInRange(startNum, endNum))
            {
                Console.Write(prefix + foundPrime);
                prefix = ", ";
            }

        }

        static List<long> FindPrimesInRange(long startNum, long endNum)
        {
            List<long> result = new List<long>();
            for (long i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    result.Add(i); ;
                }
            }
            return result;
        }

        static bool IsPrime(long n)
        {
            if (n == 0 || n == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

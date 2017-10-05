namespace MasterNumbers
{
    using System;
    using System.Diagnostics;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            //int num = int.MaxValue / 2;
            
            for (int i = 1; i <= num; i++)
            {
                if ((SumOfDigits(i) % 7 == 0) && IsPalindrome(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

            //Process currentProc = Process.GetCurrentProcess();
            //long memoryUsed = currentProc.PrivateMemorySize64;
            //double memoryMB = 1.0 * memoryUsed / 1024 / 1024;
            //Console.WriteLine(memoryMB);
        }

        static bool IsPalindrome(int num) 
        {
            string numString = Math.Abs(num).ToString();
            int frontCounter = -1;
            for (int i = numString.Length - 1; i >= numString.Length / 2; i--)
            {
                frontCounter++;
                int frontDigit = int.Parse(numString[frontCounter].ToString());
                int backDigit = int.Parse(numString[i].ToString());
                if (frontDigit != backDigit)
                {
                    return false;
                }
            }
            return true;
        }

        static double SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += (num % 10);
                num /= 10;
            }
            //string numString = Math.Abs(num).ToString();          
            //foreach (char digit in numString)
            //{
            //    sum += int.Parse(digit.ToString());
            //}
            return sum;
        }

        static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            //string numString = Math.Abs(num).ToString();           
            //foreach (char digit in numString)
            //{
            //    if (int.Parse(digit.ToString()) % 2 == 0)
            //    {
            //        return true;
            //    }
            //}
            return false;
        }
    }
}

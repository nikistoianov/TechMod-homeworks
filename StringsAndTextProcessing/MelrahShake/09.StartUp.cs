using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            //string input = "aaaa";
            //string pattern = "aa";

            string result = input;
            while (pattern.Length > 0)
            {
                int firstIndex = result.IndexOf(pattern);
                int lastIndex = result.LastIndexOf(pattern);
                if (firstIndex > -1 && lastIndex > -1 && lastIndex - firstIndex >= pattern.Length)
                {
                    result = result.Remove(firstIndex, pattern.Length).Remove(lastIndex - pattern.Length, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    //Console.WriteLine("No shake.");
                    //Console.WriteLine(result);
                    break;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(result);
        }
    }
}

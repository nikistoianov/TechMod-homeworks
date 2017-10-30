using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CameraView
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string pattern = $@"\|<.{{{arr[0]}}}([^\|]{{1,{arr[1]}}})";
            string input = Console.ReadLine();
            string suff = "";
            foreach (Match m in Regex.Matches(input, pattern))
            {                
                Console.Write(suff + m.Groups[1]);
                if (suff == "")
                {
                    suff = ", ";
                }
            }
            Console.WriteLine();
        }
    }
}

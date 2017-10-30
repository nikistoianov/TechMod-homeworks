using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyReplacer
{
    class Program
    {
        static void Main()
        {
            string keyString = Console.ReadLine();
            string text = Console.ReadLine();
            string[] keys = Regex.Split(keyString, $"[|\\<]");
            string result = "";

            if (!Regex.IsMatch(keys[0], @"^[A-Za-z]+$"))
            {
                //throw new Exception();
                Console.WriteLine("Empty result");
                return;
            }

            string pattern = $@"{keys[0]}(.*?){keys.Last()}";
            foreach (Match m in Regex.Matches(text, pattern))
            {
                //Console.Write(m.Groups[1]);
                result += m.Groups[1];
            }

            if (result == "")
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}

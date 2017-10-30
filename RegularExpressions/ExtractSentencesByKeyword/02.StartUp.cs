using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            //string word = "to";
            //string input = "Welcome to SoftUni! You will learn programming, algorithms, problem solving and " +
            //    "software technologies. You need to allocate for study 20 - 30 hours weekly.Good luck! " +
            //    "I am fan of Motorhead.To be or not to be - that is the question. TO DO OR NOT ? ";

            string pattern = @"[.?!] *";
            Regex regX = new Regex(pattern);
            string[] sentences = regX.Split(input);
            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, $@"[\W]+{word}[\W]+"))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}

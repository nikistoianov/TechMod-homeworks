using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
    
            MatchCollection lines = ExtractBetweenTags(input, "p");
            List<string> manual = new List<string>();
            foreach (Match line in lines)
            {
                manual.Add(DecriptText(line.Groups[2].Value));
            }

            Console.WriteLine(String.Join("", manual));
        }

        private static string DecriptText(string line)
        {
            string replacedLine = Regex.Replace(line, @"[^a-z\d]+", " ");
            //replacedLine = Regex.Replace(replacedLine, @"\s+", " ");
            string decodedLine = "";
            // 97 - a
            // 109 - m
            // 110 - n
            // 122 - z
            foreach (char ch in replacedLine)
            {
                char decodedCh = ch;
                if (ch >= 97 && ch <= 109)
                {
                    decodedCh = (char)((int)ch + 13);
                }
                else if (ch >= 110 && ch <= 122)
                {
                    decodedCh = (char)((int)ch - 13);
                }
                decodedLine += decodedCh;
            }
            return decodedLine;
        }

        private static MatchCollection ExtractBetweenTags(string input, string tag)
        {
            //string pattern = $@"(\<{tag}.*?\>)(.*?)(\<\/{tag}\>)";
            string pattern = $@"(\<{tag}\>)(.*?)(\<\/{tag}\>)";
            MatchCollection result = Regex.Matches(input, pattern);
            return result;
        }
    }
}

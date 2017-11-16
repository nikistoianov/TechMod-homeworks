using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryMess
{
    class Program
    {
        static void Main()
        {
            string pattern = @"([^&]+)=([^&]+)";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            while (input != "END")
            {

                var fields = new Dictionary<string, string>();

                foreach (Match match in regex.Matches(input))
                {
                    string key = match.Groups[1].Value;
                    string value = match.Groups[2].Value;

                    key = Regex.Match(key, @"[^?]+$").Value;
                    value = Regex.Match(value, @"^[^?]+").Value;

                    key = Regex.Replace(key, @"(%20|\+)+", " ").Trim();
                    value = Regex.Replace(value, @"(%20|\+)+", " ").Trim();
                    //var newKey = key.Replace("%20", " ");

                    if (fields.ContainsKey(key))
                    {
                        fields[key] += ", " + value;
                    }
                    else
                    {
                        fields[key] = value;
                    }
                }

                foreach (var item in fields)
                {
                    Console.Write($"{item.Key}=[{item.Value}]");
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }            
        }
    }
}

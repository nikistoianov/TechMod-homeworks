﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main()
        {
            string pattern = @"([\w.-]+)@[a-zA-Z]([a-zA-Z0-9-.]+)\.([a-zA-Z0-9-]+)";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                if (!m.Value.StartsWith("-") && !m.Value.StartsWith("_") && !m.Value.StartsWith(".") && !m.Value.EndsWith("-") && !m.Value.EndsWith("."))
                {
                    Console.WriteLine(m.Value);
                }                
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            foreach (var ch in input)
            {
                Console.Write("\\u" + ((int)ch).ToString("X4").ToLower());
            }
        }
    }
}

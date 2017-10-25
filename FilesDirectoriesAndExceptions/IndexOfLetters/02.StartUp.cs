using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            string[] inputLines = File.ReadAllLines(@"..\..\input.txt");
            File.WriteAllText(@"..\..\output.txt", "");
            foreach (var word in inputLines)
            {
                char[] alphabet = CreateAlphabet();

                foreach (char letter in word)
                {
                    int index = FindIndex(letter, alphabet);
                    File.AppendAllText(@"..\..\output.txt", $"{letter} -> {index}" + Environment.NewLine);
                    Console.WriteLine($"{letter} -> {index}");
                }
                File.AppendAllText(@"..\..\output.txt", Environment.NewLine);
                Console.WriteLine();
            }           
        }

        private static int FindIndex(char letter, char[] alphabet)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter == alphabet[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private static char[] CreateAlphabet()
        {
            char[] result = new char['z' - 'a' + 1];
            char firstChar = 'a';

            for (char i = 'a'; i <= 'z'; i++)
            {
                result[i - firstChar] = i;
            }

            return result;
        }
    }
}

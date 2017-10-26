using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "Clint Eastwaa";
            string[] words = input.Split();
            string shorterWord = words[0].Length > words[1].Length ? words[1] : words[0];
            string longerWord = words[0].Length > words[1].Length ? words[0] : words[1];
            HashSet<char> mapChars = new HashSet<char>();
            string mapWord = shorterWord;
            for (int i = 0; i < shorterWord.Length; i++)
            {
                char baseChar = shorterWord[i], mapChar = longerWord[i];
                if (!mapChars.Contains(mapChar))
                {
                    mapChars.Add(mapChar);
                    var skipped = mapWord.Substring(0, i);
                    var remaining = mapWord.Substring(i);
                    mapWord = skipped + remaining.Replace(baseChar, mapChar);
                }
            }

            bool exchangeable = false;
            if (shorterWord.Length == longerWord.Length)
            {
                exchangeable = mapWord == longerWord;
            }
            else
            {
                var start = longerWord.Substring(0, shorterWord.Length);
                if (start == mapWord)
                {
                    exchangeable = true;
                    var remaining = longerWord.Substring(shorterWord.Length);
                    foreach (var ch in remaining)
                    {
                        if (!mapChars.Contains(ch))
                        {
                            exchangeable = false;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(exchangeable.ToString().ToLower());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            //string command = "Pesho: 6H, 7S, KC, KD, 5S, 10C";
            var players = new Dictionary<string, string>();

            while (command != "JOKER")
            {
                string[] arr = command.Split(':');
                string name = arr[0], cardSequence = arr[1];
                //int totalValue = CalculateCardValue(cardSequence);
                
                if (players.ContainsKey(name))
                {
                    players[name] +=", " + cardSequence;
                }
                else
                {
                    players[name] = cardSequence;
                }

                command = Console.ReadLine();
            }

            foreach (var item in players)
            {
                Console.WriteLine($"{item.Key}: {CalculateCardValue(item.Value)}");
            }
        }

        private static int CalculateCardValue(string cardSequence)
        {
            var cards = cardSequence.Split(',').Select(x => x.Trim()).Distinct().ToArray();
            var powerDict = new Dictionary<string, int>(){ { "J", 11 }, { "Q", 12 }, { "K", 13 }, { "A", 14 }};
            var typeDict = new Dictionary<char, int>() { { 'S', 4 }, { 'H', 3 }, { 'D', 2 }, { 'C', 1 } };
            int sum = 0;
            
            foreach (var card in cards)
            {
                string power = card.Remove(card.Length - 1, 1);
                int powerVal = 0;
                if (powerDict.ContainsKey(power))
                {
                    powerVal = powerDict[power];
                }
                else
                {
                    powerVal = int.Parse(power);
                }
                int typeVal = typeDict[card.Last()];
                sum += typeVal * powerVal;
            }

            return sum;
        }
    }
}

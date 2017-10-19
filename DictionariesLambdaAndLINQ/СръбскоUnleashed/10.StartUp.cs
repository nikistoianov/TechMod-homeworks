using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СръбскоUnleashed
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "Lepa Brena @Belgrade ds 125 12378";
            var venues = new Dictionary<string, Dictionary<string, long>>();

            while (input != "End")
            {
                string singer = "", venue = "";
                int ticketsPrize = 0;
                int ticketsCount = 0;
                if (InputAccepted(input, ref singer, ref venue, ref ticketsPrize, ref ticketsCount))
                {
                    AddToCustomImplementedDict(venues, venue, singer, ticketsCount * ticketsPrize);
                }
                input = Console.ReadLine();
                //input = "End";
            }

            foreach (var venue in venues)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
            
        }
        
        public static void AddToCustomImplementedDict(Dictionary<string, Dictionary<string, long>> dict, string primeKey, string innerKey, long count)
        {
            if (dict.ContainsKey(primeKey))
            {
                if (dict[primeKey].ContainsKey(innerKey))
                {
                    dict[primeKey][innerKey] += count;
                }
                else
                {
                    dict[primeKey][innerKey] = count;
                }
            }
            else
            {
                dict[primeKey] = new Dictionary<string, long>();
                dict[primeKey][innerKey] = count;
            }
        }
        
        private static bool InputAccepted(string inputLine, ref string singer, ref string venue, ref int ticketsPrize, ref int ticketsCount)
        {
            try
            {
                string[] arr = inputLine.Split(new string[] { " @" }, StringSplitOptions.None);
                if (arr.Length < 2) return false;

                singer = arr[0];
                arr = arr[1].Split();
                if (arr.Length < 3) return false;

                venue = string.Join(" ", arr.Take(arr.Length - 2));
                ticketsPrize = int.Parse(arr[arr.Length - 2]);
                ticketsCount = int.Parse(arr.Last());
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

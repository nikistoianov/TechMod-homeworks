using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            string[] phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."
            };
            string[] events =
                {
                    "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
                };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] sities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string phrase = phrases[rnd.Next(0, phrases.Length)];
                string eventt = events[rnd.Next(0, events.Length)];
                string author = authors[rnd.Next(0, authors.Length)];
                string city = sities[rnd.Next(0, sities.Length)];
                Console.WriteLine($"{phrase} {eventt} {author} – {city}.");
            }
        }
    }
}

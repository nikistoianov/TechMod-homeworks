using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var countries = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                string[] arr = input.Split('|');
                string city = arr[0], country = arr[1];
                int population = int.Parse(arr[2]);

                if (countries.ContainsKey(country))
                {
                    if (countries[country].ContainsKey(city))
                    {
                        countries[country][city] += population;
                    }
                    else
                    {
                        countries[country][city] = population;
                    }
                }
                else
                {
                    countries[country] = new Dictionary<string, long>();
                    countries[country][city] = population;
                }
                
                input = Console.ReadLine();
            }
            
            foreach (var country in countries.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main()
        {
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            var cities = new Dictionary<string, City>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                Match found = Regex.Match(input, pattern);
                if (found.Length > 0)
                {
                    string city = found.Groups[1].Value;
                    double temperature = double.Parse(found.Groups[2].Value);
                    string weather = found.Groups[3].Value;

                    cities[city] = new City { averageTemperature = temperature, typeOfWeather = weather};
                }
                
                input = Console.ReadLine();
            }

            foreach (var city in cities.OrderBy(x => x.Value.averageTemperature))
            {
                Console.WriteLine($"{city.Key} => {city.Value.averageTemperature:F2} => {city.Value.typeOfWeather}");
            }
        }
    }

    public class City
    {
        public double averageTemperature { get; set; }
        public string typeOfWeather { get; set; }
    }
}

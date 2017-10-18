using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            var resources = new Dictionary<string, int>();
            while (command != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(command))
                {
                    resources[command] += quantity;
                }
                else
                {
                    resources[command] = quantity;
                }
                
                command = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

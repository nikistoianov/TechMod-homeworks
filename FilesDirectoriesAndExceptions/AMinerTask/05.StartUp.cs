using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main()
        {
            string[] inputLines = File.ReadAllLines(@"..\..\input.txt");
            int i = 0;
            
            var resources = new Dictionary<string, int>();
            while (inputLines[i] != "stop")
            {
                string command = inputLines[i];
                int quantity = int.Parse(inputLines[i + 1]);

                if (resources.ContainsKey(command))
                {
                    resources[command] += quantity;
                }
                else
                {
                    resources[command] = quantity;
                }

                i += 2;
            }

            File.WriteAllText(@"..\..\output.txt", "");
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
                File.AppendAllText(@"..\..\output.txt", $"{item.Key} -> {item.Value}" + Environment.NewLine);
            }
        }
    }
}

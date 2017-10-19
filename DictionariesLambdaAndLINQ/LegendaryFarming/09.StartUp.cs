using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            var keyMaterials = new Dictionary<string, int>() { { "fragments", 0}, { "shards", 0 }, { "motes", 0 } };
            var junkMaterials = new SortedDictionary<string, int>();
            bool legendaryObtained = false;
            string legendaryName = "";

            while (!legendaryObtained)
            {
                //string input = "12 Motes 5 stones 5 Shards 6 leathers 25 fragments 257 Shards";
                string input = Console.ReadLine();
                string[] arr = input.ToLower().Split();
                for (int i = 0; i < arr.Length; i+=2)
                {
                    int quantity = int.Parse(arr[i]);
                    string material = arr[i + 1];
                    //Console.WriteLine($"{material} -> {quantity}");

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material] >= 250 && !legendaryObtained)
                        {
                            legendaryObtained = true;
                            keyMaterials[material] -= 250;
                            switch (material)
                            {
                                case "fragments": legendaryName = "Valanyr"; break;
                                case "shards": legendaryName = "Shadowmourne"; break;
                                case "motes": legendaryName = "Dragonwrath"; break;
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] += quantity;
                        }
                        else
                        {
                            junkMaterials[material] = quantity;
                        }
                    }
                }

                //legendaryObtained = true;
            }

            Console.WriteLine($"{legendaryName} obtained!");
            foreach (var material in keyMaterials.OrderBy(x => -x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var material in junkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class Program
    {
        static void Main()
        {
            var dragonTypes = new Dictionary<string, SortedDictionary<string, DragonStats>>();
            int count = int.Parse(Console.ReadLine());
            //int count = 2;
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                //string input = "Gold Zzazx null 1000 10" + i;
                string[] arr = input.Split();
                string type = arr[0], name = arr[1];
                int damage = 45, health = 250, armor = 10;
                if (arr[2] != "null") damage = int.Parse(arr[2]);
                if (arr[3] != "null") health = int.Parse(arr[3]);
                if (arr[4] != "null") armor = int.Parse(arr[4]);
                
                if (!dragonTypes.ContainsKey(type))
                {
                    dragonTypes.Add(type, new SortedDictionary<string, DragonStats>());
                }
                if (!dragonTypes[type].ContainsKey(name))
                {
                    dragonTypes[type].Add(name, new DragonStats());
                }
                dragonTypes[type][name].damage = damage;
                dragonTypes[type][name].health = health;
                dragonTypes[type][name].armor = armor;
            }

            foreach (var dragonType in dragonTypes)
            {
                var vals = dragonType.Value.Values;
                Console.WriteLine($"{dragonType.Key}::({vals.Average(stats => stats.damage):0.00}/{vals.Average(stats => stats.health):0.00}/{vals.Average(stats => stats.armor):0.00})");
                foreach (var dragon in dragonType.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.damage}, health: {dragon.Value.health}, armor: {dragon.Value.armor}");
                }
            }
        }
    }

    class DragonStats
    {
        public int damage { get; set; }
        public int health { get; set; }
        public int armor { get; set; }
    }
}

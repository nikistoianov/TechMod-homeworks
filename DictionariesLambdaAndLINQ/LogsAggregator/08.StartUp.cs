using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main()
        {
            int logNumber = int.Parse(Console.ReadLine());
            var users = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < logNumber; i++)
            {
                string[] arr = Console.ReadLine().Split();
                string ip = arr[0];
                string user = arr[1];
                int duration = int.Parse(arr[2]);

                AddToCustomImplementedDict(users, user, ip, duration);
            }

            foreach (var user in users)
            {
                int sum = user.Value.Values.Sum();
                var ipArr = user.Value.Select(x => x.Key).ToArray();
                string ipList = string.Join(", ", ipArr);

                Console.WriteLine($"{user.Key}: {sum} [{ipList}]");
            }
        }

        public static void AddToCustomImplementedDict(SortedDictionary<string, SortedDictionary<string, int>> dict, string primeKey, string innerKey, int count)
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
                dict[primeKey] = new SortedDictionary<string, int>();
                dict[primeKey][innerKey] = count;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace UserLogs
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string input = "IP=192.23.30.40 message='Hello&derps.' user=destroyer";
            //string input = "IP=FE80:0000:0000:0000:0202:B3FF:FE1E:8329 message='Hey&son' user=mother";

            var users = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] arr = input.Split();
                string ipString = arr[0].Substring(3), user = arr[2].Substring(5);

                //IPAddress ip = IPAddress.Parse(ipString);
                //Console.WriteLine(ip.ToString());

                if (users.ContainsKey(user))
                {
                    if (users[user].ContainsKey(ipString))
                    {
                        users[user][ipString]++;
                    }
                    else
                    {
                        users[user][ipString] = 1;
                    }
                }
                else
                {
                    users[user] = new Dictionary<string, int>();
                    users[user][ipString] = 1;
                }
                //input = "end";
                input = Console.ReadLine();
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Key + ":");
                var ipOutput = user.Value.Select(x => x.Key + " => " + x.Value).ToArray();
                Console.WriteLine(string.Join(", ", ipOutput) + ".");
            }
        }
    }
}

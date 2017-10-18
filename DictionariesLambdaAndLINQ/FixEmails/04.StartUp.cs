using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            var users = new Dictionary<string, string>();

            while (command != "stop")
            {
                string email = Console.ReadLine();
                if (!email.ToLower().EndsWith("us") && !email.ToLower().EndsWith("uk"))
                {
                    users[command] = email;
                }
                command = Console.ReadLine();
            }

            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

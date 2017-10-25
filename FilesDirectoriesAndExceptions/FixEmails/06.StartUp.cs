using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main()
        {
            string[] inputLines = File.ReadAllLines(@"..\..\input.txt");
            int i = 0;
            
            var users = new Dictionary<string, string>();
            while (inputLines[i] != "stop")
            {
                string command = inputLines[i];
                string email = inputLines[i + 1];
                if (!email.ToLower().EndsWith("us") && !email.ToLower().EndsWith("uk"))
                {
                    users[command] = email;
                }
                i += 2;
            }

            File.WriteAllText(@"..\..\output.txt", "");
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
                File.AppendAllText(@"..\..\output.txt", $"{item.Key} -> {item.Value}" + Environment.NewLine);
            }
        }
    }
}

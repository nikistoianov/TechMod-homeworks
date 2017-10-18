using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            var phonebook = new Dictionary<string, string>();

            while (command != "END")
            {
                string[] arr = command.Split();
                string name = arr[1];
                if (arr[0] == "A")
                {
                    string phone = arr[2];
                    phonebook[name] = phone;
                }
                else if (arr[0] == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                
                command = Console.ReadLine();
            }
        }
    }
}

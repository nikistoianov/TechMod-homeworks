using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
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
                //string name = arr[1];
                if (arr[0] == "A")
                {
                    string name = arr[1];
                    string phone = arr[2];
                    phonebook[name] = phone;
                }
                else if (arr[0] == "S")
                {
                    string name = arr[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (arr[0] == "ListAll")
                {
                    var sortedPhonebook = phonebook.OrderBy(x => x.Key).ToArray().ToDictionary(x => x.Key, x => x.Value);
                    foreach (var item in sortedPhonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulatorr
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commandLine = Console.ReadLine();

            while (commandLine != "print")
            {
                string[] arr = commandLine.Split();
                switch (arr[0])
                {
                    case "add":
                        nums.Insert(int.Parse(arr[1]), int.Parse(arr[2]));
                        break;
                    case "addMany":
                        //List<int> elements = new List<int>(arr);
                        int[] elements = new int[arr.Length - 2];
                        for (int i = 2; i < arr.Length; i++)
                        {
                            elements[i - 2] = int.Parse((arr[i]));
                        }
                        nums.InsertRange(int.Parse(arr[1]), elements);
                        break;
                    case "contains":
                        int id = nums.IndexOf(int.Parse(arr[1]));
                        Console.WriteLine(id);
                        break;
                    case "remove":
                        nums.RemoveAt(int.Parse(arr[1]));
                        break;
                    case "shift":
                        break;
                    case "sumPairs":
                        break;

                }
                commandLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}

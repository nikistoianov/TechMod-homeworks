using System;
using System.Linq;

public class SequenceOfCommands_fixed
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            //string line = Console.ReadLine().Trim();
            string line = command.Trim();
            command = line.Split(' ')[0];
            int[] args = new int[2];

            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {
                string[] stringParams = line.Split(ArgumentsDelimiter);
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                //PerformAction(array, command, args);
            }

            PerformAction(ref array, command, args);

            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine();
        }
    }

    static void PerformAction(ref long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0] - 1;
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(ref array);
                break;
            case "rshift":
                ArrayShiftRight(ref array);
                break;
        }
        arr = array;
    }

    private static void ArrayShiftRight(ref long[] array)
    {
        long lastItem = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = lastItem;
    }

    private static void ArrayShiftLeft(ref long[] array)
    {
        long firstItem = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = firstItem;
    }

    private static void PrintArray(long[] array)
    {        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }        
    }
}

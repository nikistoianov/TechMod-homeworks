﻿namespace MagicLetter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        if (i != third && j != third && k != third) Console.Write(i.ToString() + j + k + " ");
                    }
                }                
            }
        }
    }
}

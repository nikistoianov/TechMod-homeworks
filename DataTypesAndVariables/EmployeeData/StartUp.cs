﻿namespace EmployeeData
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long personalId = long.Parse(Console.ReadLine());
            int emplyeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalId);
            Console.WriteLine("Unique Employee number: {0}", emplyeeNumber);          
        }
    }
}

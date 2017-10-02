namespace VowelOrDigit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char input = char.Parse(Console.ReadLine());

            if (input >= 48 && input <= 57) Console.WriteLine("digit");
            else if (input == 'a' || input == 'o' || input == 'i' || input == 'e' || input == 'u' || input == 'A' || input == 'O' || input == 'I' || input == 'E' || input == 'U') Console.WriteLine("vowel");
            else Console.WriteLine("other");
        }
    }
}

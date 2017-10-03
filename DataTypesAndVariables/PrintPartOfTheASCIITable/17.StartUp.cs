namespace PrintPartOfTheASCIITable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                char outputChar = (char) i;
                Console.Write(outputChar + " ");
            }
        }
    }
}
// READY

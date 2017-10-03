namespace DifferentIntegersSize
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();
            try
            {
                long input = long.Parse(inputString);
                
                string output = input + " can fit in:";

                if (sbyte.MinValue <= input && input <= sbyte.MaxValue)
                {
                    output += Environment.NewLine + "* sbyte";
                }

                if (byte.MinValue <= input && input <= byte.MaxValue)
                {
                    output += Environment.NewLine + "* byte";
                }

                if (short.MinValue <= input && input <= short.MaxValue)
                {
                    output += Environment.NewLine + "* short";
                }

                if (ushort.MinValue <= input && input <= ushort.MaxValue)
                {
                    output += Environment.NewLine + "* ushort";
                }

                if (int.MinValue <= input && input <= int.MaxValue)
                {
                    output += Environment.NewLine + "* int";
                }

                if (uint.MinValue <= input && input <= uint.MaxValue)
                {
                    output += Environment.NewLine + "* uint";
                }

                Console.WriteLine(output);
                Console.WriteLine("* long");
                
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type", inputString);
            }
            
        }
    }
}
// READY
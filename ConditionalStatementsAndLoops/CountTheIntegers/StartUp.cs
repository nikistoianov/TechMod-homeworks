namespace CountTheIntegers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int count = 0;
            try
            {
                while (true)
                {
                    int testInteger = int.Parse(Console.ReadLine());
                    count += 1;
                }                
            }
            catch (Exception)
            {
            }
            Console.WriteLine(count);
        }
    }
}

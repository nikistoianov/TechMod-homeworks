namespace ConvertSpeedUnits
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            int totalSeconds = seconds + minutes * 60 + hours * 3600;
            float speedMPS = 1.0f * meters / totalSeconds;
            Console.WriteLine("{0}", speedMPS);

            //double totalHours = 1.0f * totalSeconds / 3600;
            float speedKPH = 1.0f * meters / 1000 / totalSeconds * 3600;
            Console.WriteLine("{0}", speedKPH);

            float speedMPH = 1.0f * meters / 1609 / totalSeconds * 3600;
            Console.WriteLine("{0}", speedMPH);

        }
    }
}
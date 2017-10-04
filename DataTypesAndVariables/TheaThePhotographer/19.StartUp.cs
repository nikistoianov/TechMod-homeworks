namespace TheaThePhotographer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int pixNumber = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            byte filterFactor = byte.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            int usefullPix = (int)(Math.Ceiling(pixNumber * filterFactor / 100.0));
            long totalFilterTime = (long)pixNumber * filterTime;
            long totalUploadTime = (long)usefullPix * uploadTime;
            long totalSeconds = totalFilterTime + totalUploadTime;

            int days = (int)Math.Floor(totalSeconds / 24.0 / 60 / 60);
            long remainingSeconds = totalSeconds - (long)days * 24 * 60 * 60;

            int hours = (int)Math.Floor(remainingSeconds / 60.0 / 60);
            remainingSeconds -= hours * 60 * 60;

            int minutes = (int)Math.Floor(remainingSeconds / 60.0);
            remainingSeconds -= minutes * 60;

            Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", days, hours, minutes, remainingSeconds);
        }
    }
}
// READY
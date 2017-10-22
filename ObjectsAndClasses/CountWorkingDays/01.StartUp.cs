using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class Program
    {
        static void Main()
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            //DateTime firstDate = new DateTime(2015, 12, 20);
            //DateTime secondDate = new DateTime(2015, 12, 31);
            int counter = 0;

            List<DateTime> holidays = new List<DateTime>()
            {
                new DateTime(1, 1, 1), new DateTime(1, 3, 3), new DateTime(1, 5, 1), new DateTime(1, 5, 6), new DateTime(1, 5, 24),
                new DateTime(1, 9, 6), new DateTime(1, 9, 22), new DateTime(1, 11, 1), new DateTime(1, 12, 24), new DateTime(1, 12, 25), new DateTime(1, 12, 26)
            };
            for (DateTime day = firstDate; day <= secondDate; day = day.AddDays(1))
            {
                var foundHolidays = holidays.Where(x => x.Month == day.Month && x.Day == day.Day).ToArray();
                if (foundHolidays.Length == 0 && day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

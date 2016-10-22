using System;
using System.Collections.Generic;
using System.Globalization;

namespace CountWorkingDates
{
    public class CountWorkingDates
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>
            {
                new DateTime(2016, 01, 01),
                new DateTime(2016, 03, 03),
                new DateTime(2016, 05, 01),
                new DateTime(2016, 05, 06),
                new DateTime(2016, 05, 24),
                new DateTime(2016, 09, 06),
                new DateTime(2016, 09, 22),
                new DateTime(2016, 11, 01),
                new DateTime(2016, 12, 24),
                new DateTime(2016, 12, 25),
                new DateTime(2016, 12, 26)
            };

            int workingDays = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                DateTime newDate = new DateTime(2016, currentDate.Month, currentDate.Day);
                if (!holidays.Contains(newDate) && currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
                
            }

            Console.WriteLine(workingDays);
        }
    }
}

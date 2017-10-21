using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[]
            {
                new DateTime(2000, 01, 01),
                new DateTime(2000, 03, 03),
                new DateTime(2000, 05, 01),
                new DateTime(2000, 05, 06),
                new DateTime(2000, 05, 24),
                new DateTime(2000, 09, 06),
                new DateTime(2000, 09, 22),
                new DateTime(2000, 11, 01),
                new DateTime(2000, 12, 24),
                new DateTime(2000, 12, 25),
                new DateTime(2000, 12, 26)
            };

            int workingDaysCntr = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                DayOfWeek currentDay = i.DayOfWeek;
                DateTime currentDate = new DateTime(2000, i.Month, i.Day);

                if (!holidays.Contains(currentDate) && (!currentDay.Equals(DayOfWeek.Saturday) && !currentDay.Equals(DayOfWeek.Sunday)))
                {
                    workingDaysCntr++;
                }
            }

            Console.WriteLine(workingDaysCntr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            string[] daysOfWeek = {"Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int n = int.Parse(Console.ReadLine());

            if (n >= 0 && n <= 7)
            {
                Console.WriteLine(daysOfWeek[n]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}

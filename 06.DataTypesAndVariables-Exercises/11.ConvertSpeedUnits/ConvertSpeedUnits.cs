using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalseconds = ((((hours * 60) + minutes) * 60) + seconds);

            Console.WriteLine(distanceInMeters / totalseconds); // The task requires rounding up to the 6th digit after the decimal point, but it doesn't work...

            float totalHours = hours + (minutes / 60 + ((seconds / 60) / 60));
            float distanceInKm = distanceInMeters / 1000;

            Console.WriteLine(distanceInKm / totalHours); // The task requires rounding up to the 6th digit after the decimal point, but it doesn't work...

            float distanceInMiles = distanceInMeters / 1609;

            Console.WriteLine(distanceInMiles / totalHours); // The task requires rounding up to the 6th digit after the decimal point, but it doesn't work...
        }
    }
}

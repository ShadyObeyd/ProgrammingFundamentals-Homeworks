using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            if (month == "may")
            {
                double studioPrice = 50.0 * nights;
                if (nights > 7)
                {
                    studioPrice = 47.5 * nights;
                }
                Console.WriteLine($"Studio: {studioPrice:f2} lv.");

                double doublePrice = 65.0 * nights;
                Console.WriteLine($"Double: {doublePrice:f2} lv.");

                double suitePrice = 75.0 * nights;
                Console.WriteLine($"Suite: {suitePrice:f2} lv.");
            }
            else if (month == "october")
            {
                double studioPrice = 50.0 * nights;
                if (nights > 7)
                {
                    studioPrice = (47.5 * nights) - 47.5;
                }
                Console.WriteLine($"Studio: {studioPrice:f2} lv.");

                double doublePrice = 65.0 * nights;
                Console.WriteLine($"Double: {doublePrice:f2} lv.");

                double suitePrice = 75.0 * nights;
                Console.WriteLine($"Suite: {suitePrice:f2} lv.");
            }
            else if (month == "june" || month == "september")
            {
                double studioPrice = 60.0 * nights;
                if (nights > 7 && month == "september")
                {
                    studioPrice = (60.0 * nights) - 60.0;
                }
                Console.WriteLine($"Studio: {studioPrice:f2} lv.");

                double doublePrice = 72.0 * nights;
                if (nights > 14)
                {
                    doublePrice = 64.8 * nights;
                }
                Console.WriteLine($"Double: {doublePrice:f2} lv.");

                double suitePrice = 82.0 * nights;
                Console.WriteLine($"Suite: {suitePrice:f2} lv.");
            }
            else if (month == "july" || month == "august" || month == "december")
            {
                double studioPrice = 68.0 * nights;
                Console.WriteLine($"Studio: {studioPrice:f2} lv.");

                double doublePrice = 77.0 * nights;
                Console.WriteLine($"Double: {doublePrice:f2} lv.");

                double suitePrice = 89.0 * nights;
                if (nights > 14)
                {
                    suitePrice = 75.65 * nights;
                }
                Console.WriteLine($"Suite: {suitePrice:f2} lv.");
            }
        }
    }
}

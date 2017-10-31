using System;
using System.Globalization;

namespace _01.SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main()
        {
            DateTime leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long stepsToHome = long.Parse(Console.ReadLine()) % 86400;
            long secsPerStep = long.Parse(Console.ReadLine()) % 86400;

            long totalSeconds = secsPerStep * stepsToHome;

            leavingTime = leavingTime.AddSeconds(totalSeconds);

            Console.WriteLine($"Time Arrival: {leavingTime.ToString("HH:mm:ss")}");

        }
    }
}

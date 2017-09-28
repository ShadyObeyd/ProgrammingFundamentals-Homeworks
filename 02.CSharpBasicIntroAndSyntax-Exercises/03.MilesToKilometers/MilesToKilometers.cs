using System;
namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main()
        {
            double milesToKm = double.Parse(Console.ReadLine()) * 1.60934;

            Console.WriteLine($"{milesToKm:f2}");
        }
    }
}

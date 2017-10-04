using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main()
        {
            double tempInFarenheit = double.Parse(Console.ReadLine());

            double tempInCelsius = GetTempInCelsius(tempInFarenheit);

            Console.WriteLine($"{tempInCelsius:f2}");
        }

        private static double GetTempInCelsius(double tempInFarenheit)
        {
            return (tempInFarenheit - 32) * 5 / 9;
        }
    }
}

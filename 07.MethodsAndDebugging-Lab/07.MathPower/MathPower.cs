using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MathPower
{
    class MathPower
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = GetNumPower(number, power);

            Console.WriteLine(result);
        }

        private static double GetNumPower(double number, double power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}

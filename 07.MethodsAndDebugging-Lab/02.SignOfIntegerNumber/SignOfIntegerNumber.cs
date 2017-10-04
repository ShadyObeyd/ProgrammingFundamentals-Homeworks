using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string numberSign = DetermineSign(number);

            Console.WriteLine($"The number {number} is {numberSign}.");
        }

        private static string DetermineSign(int number)
        {
            string result = string.Empty;

            if (number > 0)
            {
                result = "positive";
            }
            else if (number == 0)
            {
                result = "zero";
            }
            else if (number < 0)
            {
                result = "negative";
            }

            return result;
        }
    }
}

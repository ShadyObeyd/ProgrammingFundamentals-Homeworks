using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = MultilpiedEvensAndOdds(number);

            Console.WriteLine(result);
        }

        private static int MultilpiedEvensAndOdds(int number)
        {
            int summedEvens = SummEvenDigits(number);
            int summedOdds = SummOddDiggits(number);

            return summedEvens * summedOdds;
        }

        private static int SummOddDiggits(int number)
        {
            int summedOddDigits = 0;

            while (number > 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 != 0)
                {
                    summedOddDigits += currentDigit;
                }

                number /= 10;
            }

            return summedOddDigits;
        }

        private static int SummEvenDigits(int number)
        {
            int summedEvenDigits = 0;

            while (number > 0)
            {
                int currentDigit = number % 10;

                if (currentDigit % 2 == 0)
                {
                    summedEvenDigits += currentDigit;
                }
                number /= 10;
            }

            return summedEvenDigits;
        }
    }
}

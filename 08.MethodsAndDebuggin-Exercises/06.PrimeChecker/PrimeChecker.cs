using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(num);

            Console.WriteLine(isPrime);
        }

        private static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

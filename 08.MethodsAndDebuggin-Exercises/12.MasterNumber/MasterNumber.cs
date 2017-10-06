using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class MasterNumber
    {
        static void Main()
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            for (int i = 1; i <= num; i++)
            {
                bool isMasterNumber = IsPalindrome(i) && ContainsEvenDigit(i) && SumDigits(i) % 7 == 0;

                if (isMasterNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPalindrome(int num)
        {
            int initialNum = num;
            int result = 0;

            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }

            if (result == initialNum)
            {
                return true;
            }
            return false;
        }

        private static int SumDigits(int num)
        {
            int digitsSum = 0;

            while (num > 0)
            {
                int currentDigit = num % 10;

                digitsSum += currentDigit;

                num /= 10;
            }

            return digitsSum;
        }

        private static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                int currentDigit = num % 10;

                if (currentDigit % 2 == 0)
                {
                    return true;
                }

                num /= 10;
            }

            return false;
        }
    }
}

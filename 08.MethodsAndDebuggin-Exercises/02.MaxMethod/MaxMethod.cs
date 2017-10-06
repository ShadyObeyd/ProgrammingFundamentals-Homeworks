using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double largestNum = GetLargestNum(firstNum, secondNum);

            if (largestNum > thirdNum)
            {
                Console.WriteLine(largestNum);
            }
            else
            {
                Console.WriteLine(thirdNum);
            }

        }

        private static double GetLargestNum(double firstNum, double secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }
    }
}

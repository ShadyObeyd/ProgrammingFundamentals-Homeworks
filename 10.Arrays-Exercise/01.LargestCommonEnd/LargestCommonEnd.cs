using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] first = Console.ReadLine().Split(' ');
            string[] second = Console.ReadLine().Split(' ');

            int leftCntr = 0;
            int rightCntr = 0;

            while (leftCntr < first.Length && leftCntr < second.Length)
            {
                if (first[leftCntr] == second[leftCntr])
                {
                    leftCntr++;
                }
                else
                {
                    break;
                }
            }

            while (rightCntr < first.Length && rightCntr < second.Length)
            {
                if (first[first.Length - 1 - rightCntr] == second[second.Length - 1 - rightCntr])
                {
                    rightCntr++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(leftCntr, rightCntr));
        }
    }
}

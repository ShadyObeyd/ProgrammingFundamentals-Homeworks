using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int start = 0;
            int end = 1;
            int sum = 1;

            int wantedNum = GetNthFibonacciNum(start, end, sum, n);

            Console.WriteLine(wantedNum);
        }

        private static int GetNthFibonacciNum(int start, int end, int sum, int n)
        {
            for (int i = 0; i < n; i++)
            {
                sum = start + end;

                start = end;
                end = sum;
            }

            return sum;
        }
    }
}

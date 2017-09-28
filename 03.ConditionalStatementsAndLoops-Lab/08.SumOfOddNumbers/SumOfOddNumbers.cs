using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int currentNum = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(currentNum);
                sum += currentNum;
                currentNum += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

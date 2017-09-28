using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main()
        {
            int firtstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int restrictedSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int comboCntr = 0;

            for (int i = firtstNum; i > 0; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    comboCntr++;
                    sum = sum + (3 * (i * j));
                    if (sum >= restrictedSum)
                    {
                        Console.WriteLine($"{comboCntr} combinations");
                        Console.WriteLine($"Sum: {sum} >= {restrictedSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{comboCntr} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

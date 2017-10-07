using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] result = new long[n];

            result[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int start = Math.Max(0, i - k);
                int end = i - 1;
                long sum = 0;

                for (int j = start; j <= end; j++)
                {
                    sum += result[j];
                }
                result[i] = sum;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

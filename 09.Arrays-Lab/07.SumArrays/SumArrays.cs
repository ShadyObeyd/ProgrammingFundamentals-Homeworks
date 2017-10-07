using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main()
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = new int[Math.Max(first.Length, second.Length)];

            for (int i = 0; i < Math.Max(first.Length, second.Length); i++)
            {
                result[i] = first[i % first.Length] + second[i % second.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

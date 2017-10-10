using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sumArr = new int[numbers.Length];

            for (int i = 0; i < k; i++)
            {
                int last = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j > 0; j--) 
                {
                    numbers[j] = numbers[j - 1];
                    sumArr[j] += numbers[j];
                }
                numbers[0] = last;
                sumArr[0] += numbers[0];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}

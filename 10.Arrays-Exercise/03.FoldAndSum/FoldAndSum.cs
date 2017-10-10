using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] firsHalf = numbers
                .Take(numbers.Length / 4)
                .Reverse()
                .ToArray();

            int[] secondHalf = numbers
                .Reverse()
                .Take(numbers.Length / 4)
                .ToArray();

            int[] middlePart = numbers
                .Skip(firsHalf.Length)
                .Take(numbers.Length / 2)
                .ToArray();

            int[] firstPlusSecond = firsHalf.Concat(secondHalf).ToArray();

            int[] resultArr = new int[middlePart.Length];

            for (int i = 0; i < middlePart.Length; i++)
            {
                resultArr[i] = firstPlusSecond[i] + middlePart[i];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
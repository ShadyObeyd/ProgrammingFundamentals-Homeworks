using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] lenght = new int[numbers.Count];
            int[] prev = new int[numbers.Count];

            int maxLenght = 0;
            int lastIndex = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                lenght[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && lenght[j] >= lenght[i])
                    {
                        lenght[i] = 1 + lenght[j];
                        prev[i] = j;
                    }
                }

                if (lenght[i] > maxLenght)
                {
                    maxLenght = lenght[i];
                    lastIndex = i;
                }
            }

            List<int> result = new List<int>();

            for (int i = 0; i < maxLenght; i++)
            {
                result.Add(numbers[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            result.Reverse();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

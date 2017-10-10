using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int cntr = 0;
            int longestOccurence = 0;
            int mostFrequentNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                cntr = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        cntr++;
                    }
                }

                if (cntr > longestOccurence)
                {
                    longestOccurence = cntr;
                    mostFrequentNum = numbers[i];
                }
            }

            Console.WriteLine(mostFrequentNum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualNumbers
{
    class MaxSequenceOfEqualNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int lenght = 1;
            int maxLenght = 1;
            int number = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                }

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    number = numbers[i];
                }
            }

            if (maxLenght > 1)
            {
                for (int i = 0; i < maxLenght; i++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(numbers[0]);
            }

        }
    }
}

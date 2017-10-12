using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class BombNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int number = bomb[0];
            int power = bomb[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum == number)
                {
                    int leftIndex = Math.Max(0, i - power);
                    int rightIndex = Math.Min(numbers.Count, i + power);

                    int lenght = rightIndex - leftIndex + 1;

                    numbers.RemoveRange(leftIndex, lenght);
                    
                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}

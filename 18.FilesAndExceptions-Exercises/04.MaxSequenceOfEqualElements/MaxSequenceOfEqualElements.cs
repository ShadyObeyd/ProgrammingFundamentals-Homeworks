using System;
using System.IO;
using System.Linq;

namespace _04.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            int[] numbers = File.ReadAllText("Input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            File.Delete("Output.txt");

            int lenght = 1;
            int maxLenght = 1;
            int number = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
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

            for (int i = 0; i < maxLenght; i++)
            {
                File.AppendAllText("Output.txt", number.ToString() + " ");
            }
        }
    }
}

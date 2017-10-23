using System;
using System.IO;
using System.Linq;

namespace _01.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            int[] numbers = File.ReadAllText("Input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int cntr = 0;
            int maxCntr = 0;
            int number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                cntr = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        cntr++;
                    }
                }

                if (cntr > maxCntr)
                {
                    maxCntr = cntr;
                    number = numbers[i];
                }
            }

            File.WriteAllText("Output.txt", number.ToString());
        }
    }
}

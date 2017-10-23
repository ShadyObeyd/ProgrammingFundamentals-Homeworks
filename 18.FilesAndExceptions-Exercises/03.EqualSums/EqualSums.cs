using System;
using System.Linq;
using System.IO;

namespace _03.EqualSums
{
    class EqualSums
    {
        static void Main()
        {
            int[] numbers = File.ReadAllText("Input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool areEqual = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftPart = numbers.Take(i).ToArray();
                int[] rightPart = numbers.Skip(i + 1).ToArray();

                if (leftPart.Sum() == rightPart.Sum())
                {
                    File.WriteAllText("Output.txt", i.ToString());
                    areEqual = true;
                    break;
                }
            }

            if (!areEqual)
            {
                File.WriteAllText("Output.txt", "no");
            }
        }
    }
}

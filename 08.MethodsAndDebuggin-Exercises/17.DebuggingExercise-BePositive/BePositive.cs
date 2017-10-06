using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            int[] input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> data = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                int currentNum = input[j];

                if (currentNum >= 0)
                {
                    data.Add(currentNum);
                }
                else
                {
                    if (j < input.Length - 1)
                    {
                        currentNum += input[j + 1];
                    }

                    if (currentNum >= 0)
                    {
                        data.Add(currentNum);
                    }
                    j++;
                }
            }

            if (data.Count > 0)
            {
                Console.WriteLine(string.Join(" ", data));
            }
            else
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}

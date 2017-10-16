using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Random random = new Random();

            string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputTokens.Length; i++)
            {
                int index = random.Next(0, inputTokens.Length);

                string temp = inputTokens[i];
                inputTokens[i] = inputTokens[index];
                inputTokens[index] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, inputTokens));
        }
    }
}

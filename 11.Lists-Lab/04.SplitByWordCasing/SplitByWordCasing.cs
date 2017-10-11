using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowercaseWords = new List<string>();
            List<string> mixedcaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                string currentWord = input[i];

                int lowercaseCntr = 0;
                int uppercaseCntr = 0;

                foreach (char letter in currentWord)
                {
                    if (char.IsLower(letter))
                    {
                        lowercaseCntr++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        uppercaseCntr++;
                    }
                }

                if (lowercaseCntr == currentWord.Length)
                {
                    lowercaseWords.Add(currentWord);
                }
                else if (uppercaseCntr == currentWord.Length)
                {
                    upperCaseWords.Add(currentWord);
                }
                else
                {
                    mixedcaseWords.Add(currentWord);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowercaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedcaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}

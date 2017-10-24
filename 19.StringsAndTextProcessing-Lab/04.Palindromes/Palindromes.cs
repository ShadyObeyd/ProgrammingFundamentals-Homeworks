using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];
                string reversed = ReverseString(currentWord);

                if (currentWord == reversed)
                {
                    palindromes.Add(reversed);
                }
            }

            palindromes.Sort();

            Console.WriteLine(string.Join(", ", palindromes.Distinct()));
        }

        private static string ReverseString(string currentWord)
        {
            string reversed = string.Empty;

            for (int i = currentWord.Length - 1; i >= 0; i--)
            {
                reversed += currentWord[i];
            }
            return reversed;
        }
    }
}

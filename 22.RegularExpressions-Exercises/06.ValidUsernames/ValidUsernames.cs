using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    class ValidUsernames
    {
        static void Main()
        {
            Regex pattern = new Regex(@"\b[A-Za-z][\w]{2,24}\b");

            string[] usernames = Console.ReadLine().Split(new char[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames = new List<string>();

            ValidateUsernames(usernames, validUsernames, pattern);

            int maxLenght = 0;

            string firstString = string.Empty;
            string secondString = string.Empty;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                int lenght = validUsernames[i].Length + validUsernames[i + 1].Length;

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    firstString = validUsernames[i];
                    secondString = validUsernames[i + 1];
                }
            }

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
        }

        static void ValidateUsernames(string[] usernames, List<string> validUsernames, Regex pattern)
        {
            for (int i = 0; i < usernames.Length; i++)
            {
                if (pattern.IsMatch(usernames[i]))
                {
                    validUsernames.Add(usernames[i]);
                }
            }
        }
    }
}

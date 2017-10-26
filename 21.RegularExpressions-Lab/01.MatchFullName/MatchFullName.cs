using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            Regex pattern = new Regex(@"\b[A-Z][a-z]+\b \b[A-Z][a-z]+\b");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write($"{match} ");
            }
            Console.WriteLine();
        }
    }
}

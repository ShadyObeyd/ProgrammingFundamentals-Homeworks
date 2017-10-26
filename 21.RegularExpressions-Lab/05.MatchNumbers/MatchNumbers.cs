using System;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class MatchNumbers
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write($"{match} ");
            }
        }
    }
}

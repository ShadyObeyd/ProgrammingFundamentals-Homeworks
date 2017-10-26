using System;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main()
        {
            Regex pattern = new Regex(@"\b(0x)?([0-9A-F]+)\b");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                Console.Write($"{match} ");
            }
        }
    }
}

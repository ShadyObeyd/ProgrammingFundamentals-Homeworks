using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main()
        {
            Regex pattern = new Regex(@"\+359([-| ])2\1[\d]{3}\1[\d]{4}\b");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    class MatchDates
    {
        static void Main()
        {
            Regex pattern = new Regex(@"\b(?<day>\d{2})([.\/-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}

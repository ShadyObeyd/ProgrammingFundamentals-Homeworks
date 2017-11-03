using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    class RageQuit
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(?<symbols>[^\d]+)(?<nums>[\d]+)");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            StringBuilder builder = new StringBuilder();

            foreach (Match match in matches)
            {
                string text = match.Groups["symbols"].Value;
                int count = int.Parse(match.Groups["nums"].Value);

                for (int i = 0; i < count; i++)
                {
                    builder.Append(text.ToUpper());
                }
            }

            Console.WriteLine($"Unique symbols used: {builder.ToString().Distinct().Count()}");

            Console.WriteLine(builder.ToString());
        }
    }
}

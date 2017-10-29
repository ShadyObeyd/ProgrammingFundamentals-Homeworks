using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(?<=<p>).*?(?=<\/p>)");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            StringBuilder builder = new StringBuilder();

            foreach (Match match in matches)
            {
                string currentStr = match.Value;
                currentStr = Regex.Replace(currentStr, @"[^a-z0-9]", " ");

                currentStr = ReplaceLetters(currentStr);

                currentStr = Regex.Replace(currentStr, @"\s+", " ");

                builder.Append(currentStr);
            }

            Console.WriteLine(builder);
        }

        private static string ReplaceLetters(string currentStr)
        {
            StringBuilder builder = new StringBuilder();

            foreach (char letter in currentStr)
            {
                if (letter >= 'a' && letter <= 'm')
                {
                    builder.Append((char)(letter + 13));
                }
                else if (letter >= 'n' && letter <= 'z')
                {
                    builder.Append((char)(letter - 13));
                }
                else
                {
                    builder.Append(letter);
                }
            }

            return builder.ToString();
        }
    }
}

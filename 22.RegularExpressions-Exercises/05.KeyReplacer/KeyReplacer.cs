using System;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class KeyReplacer
    {
        static void Main()
        {
            Regex pattern = new Regex(@"^(?<start>[A-Za-z]+)[<\\\|]{1}.*[<\|\\]{1}(?<end>[A-Za-z]+)$");

            string inputPattern = Console.ReadLine();

            Match match = pattern.Match(inputPattern);

            string start = match.Groups["start"].Value;
            string end = match.Groups["end"].Value;

            Regex stringPattern = new Regex($@"{start}(?<word>.*?){end}");

            string input = Console.ReadLine();

            MatchCollection matches = stringPattern.Matches(input);

            string result = string.Empty;

            foreach (Match word in matches)
            {
                result += word.Groups["word"].Value;
            }

            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
                return;
            }
            Console.WriteLine(result);
        }
    }
}

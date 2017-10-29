using System;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyWord
{
    class ExtractSentencesByKeyWord
    {
        static void Main()
        {
            string word = Console.ReadLine();
            Regex pattern = new Regex($@"\b[^.?!]*\b{word}\b[^.?!]*");

            string text = Console.ReadLine();

            MatchCollection matches = pattern.Matches(text);

            foreach (Match match in matches)
            {
                string sentence = match.Value;
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}
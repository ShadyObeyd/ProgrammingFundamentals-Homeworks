using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            Regex pattern = new Regex(@"^(?<firstLetter>^[A-Za-z]{1})(?<number>[\d]+)(?<secondLetter>[A-Za-z]{1})$");

            char[] lowerCaseAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] upperCaseAlphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentStr = input[i].Trim();

                if (pattern.IsMatch(currentStr))
                {
                    double sum = 0;
                    Match match = pattern.Match(currentStr);

                    char firstLetter = char.Parse(match.Groups["firstLetter"].ToString());
                    double number = double.Parse(match.Groups["number"].ToString());
                    char secondLetter = char.Parse(match.Groups["secondLetter"].ToString());

                    if (char.IsUpper(firstLetter))
                    {
                        sum = number / (Array.IndexOf(upperCaseAlphabet, firstLetter) + 1);
                    }
                    else if (char.IsLower(firstLetter))
                    {
                        sum = number * (Array.IndexOf(lowerCaseAlphabet, firstLetter) + 1);
                    }

                    if (char.IsUpper(secondLetter))
                    {
                        sum -= (Array.IndexOf(upperCaseAlphabet, secondLetter) + 1);
                    }
                    else if (char.IsLower(secondLetter))
                    {
                        sum += (Array.IndexOf(lowerCaseAlphabet, secondLetter) + 1);
                    }

                    totalSum += sum;
                }
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}

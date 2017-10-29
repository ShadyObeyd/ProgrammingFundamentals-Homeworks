using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmail
{
    class ExtractEmails
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(?<= |^)[A-Za-z0-9]+[A-Za-z0-9._-]*@[A-Za-z]+[A-Za-z-]*\.[A-Za-z]+(\.[A-Za-z]+)*");

            string input = Console.ReadLine();

            MatchCollection emials = pattern.Matches(input);

            foreach (Match email in emials)
            {
                Console.WriteLine(email);
            }
        }
    }
}

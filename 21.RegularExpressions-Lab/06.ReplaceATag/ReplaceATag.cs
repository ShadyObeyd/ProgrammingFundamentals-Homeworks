using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.ReplaceATag
{
    class ReplaceATag
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<string> data = new List<string>();

            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";

                string replaced = Regex.Replace(input, pattern, replacement);

                data.Add(replaced);
                input = Console.ReadLine();
            }

            foreach (string item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.QuerryMess
{
    class QuerryMess
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(?<field>[^?&]+)=(?<value>[^?&]+)");

            string input = Console.ReadLine();

            while (input != "END")
            {
                Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

                MatchCollection matches = pattern.Matches(input);

                foreach (Match match in matches)
                {
                    string field = match.Groups["field"].Value.Replace("%20", " ").Replace("+", " ").TrimStart().TrimEnd();
                    string value = match.Groups["value"].Value.Replace("%20", " ").Replace("+", " ").TrimStart().TrimEnd();
                    field = Regex.Replace(field, @"\s+", " ");
                    value = Regex.Replace(value, @"\s+", " ");

                    if (!data.ContainsKey(field))
                    {
                        data.Add(field, new List<string>());
                    }
                    data[field].Add(value);
                }

                foreach (var item in data)
                {
                    string field = item.Key;
                    List<string> values = item.Value;

                    Console.Write($"{field}=[{string.Join(", ", values)}]");
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class CameraView
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(?<=\|<)[^|<]*");

            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int elementsToSkip = arr[0];
            int elementsToTake = arr[1];

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            List<string> results = new List<string>();

            foreach (Match match in matches)
            {
                string currentStr = match.Value;

                char[] currentStrAsArr = currentStr.ToCharArray().Skip(elementsToSkip).Take(elementsToTake).ToArray();

                string result = ConvertToString(currentStrAsArr);

                results.Add(result);
            }

            Console.WriteLine(string.Join(", ", results));
        }

        private static string ConvertToString(char[] currentStrAsArr)
        {
            string result = string.Empty;

            for (int i = 0; i < currentStrAsArr.Length; i++)
            {
                result += currentStrAsArr[i];
            }
            return result;
        }
    }
}

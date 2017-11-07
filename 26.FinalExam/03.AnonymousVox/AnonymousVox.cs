using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.AnonymousVox
{
    class AnonymousVox
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(?<start>[A-Za-z]+)(?<token>.+)(?<end>\1)");

            string encodedMessage = Console.ReadLine();
            string[] values = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            MatchCollection matches = pattern.Matches(encodedMessage);

            int i = 0;

            foreach (Match match in matches)
            {
                if (i >= values.Length)
                {
                    break;
                }

                string currentStart = match.Groups["start"].Value.Trim();
                string currentToken = match.Groups["token"].Value.Trim();
                string currentEnd = match.Groups["end"].Value.Trim();

                string withOldValue = encodedMessage.Substring(0, encodedMessage.IndexOf(currentToken) + currentToken.Length);
                string withNewValue = withOldValue.Replace(currentToken, values[i]);

                encodedMessage = withNewValue + encodedMessage.Substring(withOldValue.Length);

                i++;
            }

            Console.WriteLine(encodedMessage);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurences
{
    class OddOccurences
    {
        static void Main()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();

            List<string> text = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (string word in text)
            {
                if (!data.ContainsKey(word))
                {
                    data.Add(word, 0);
                }
                data[word]++;
            }

            data = data
                .Where(v => v.Value % 2 != 0)
                .ToDictionary(k => k.Key, v => v.Value);

            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> words in data)
            {
                string word = words.Key;

                result.Add(word);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}

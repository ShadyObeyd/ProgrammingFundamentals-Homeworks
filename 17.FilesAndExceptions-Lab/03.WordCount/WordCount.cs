using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();

            string[] wordsToCheck = ReadLines("words.txt");
            string[] text = ReadLines("text.txt");

            foreach (string word in text)
            {
                if (wordsToCheck.Contains(word))
                {
                    if (!data.ContainsKey(word))
                    {
                        data.Add(word, 0);
                    }
                    data[word]++;
                }
            }

            List<string> output = new List<string>();

            foreach (KeyValuePair<string, int> wordCount in data.OrderByDescending(c => c.Value))
            {
                string word = wordCount.Key;
                int count = wordCount.Value;

                output.Add($"{word} - {count}");
            }

            File.WriteAllLines("Output.txt", output);
            
        }

        static string[] ReadLines(string path)
        {
            string[] arr = File.ReadAllText(path)
                .ToLower()
                .Split(new char[] { ';', ':', ' ', '-', ',', '?', '!', '.', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            return arr;
        }
    }
}

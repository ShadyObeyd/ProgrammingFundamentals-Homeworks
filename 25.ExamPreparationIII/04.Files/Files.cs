using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    
    class Files
    {
        static void Main()
        {
            var filesData = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] fileTokens = Console.ReadLine().Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

                string root = fileTokens[0];
                string[] fileAndSize = fileTokens[fileTokens.Length - 1].Split(';');

                string fileName = fileAndSize[0];
                long fileSize = long.Parse(fileAndSize[1]);

                if (!filesData.ContainsKey(root))
                {
                    filesData.Add(root, new Dictionary<string, long>());
                }
                filesData[root][fileName] = fileSize;
            }

            string[] toSearch = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string extensionToSearch = toSearch[0];
            string rootToSearch = toSearch[2];

            if (!filesData.ContainsKey(rootToSearch) || !filesData[rootToSearch].Keys.Any(f => f.EndsWith("." + extensionToSearch)))
            {
                Console.WriteLine("No");
                return;
            }

            filesData = filesData
                .Where(k => k.Key == rootToSearch)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in filesData)
            {
                string root = item.Key;
                Dictionary<string, long> files = item.Value
                    .Where(e => e.Key.EndsWith("." + extensionToSearch))
                    .OrderByDescending(s => s.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (KeyValuePair<string, long> file in files)
                {
                    string fileName = file.Key;
                    long fileSize = file.Value;

                    Console.WriteLine($"{fileName} - {fileSize} KB");
                }
            }

        }
    }
}

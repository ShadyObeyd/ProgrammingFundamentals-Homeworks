using System.Collections.Generic;
using System.IO;

namespace _04.MergeFiles
{
    class MergeFiles
    {
        static void Main()
        {
            List<string> output = new List<string>();

            string[] firstTextLines = ReadLines("FileOne.txt");
            string[] secondTextLines = ReadLines("FileTwo.txt");

            AddLines(output, firstTextLines);
            AddLines(output, secondTextLines);

            output.Sort();

            File.WriteAllLines("Output.txt", output);

        }

        static void AddLines(List<string> output, string[] arr)
        {
            foreach (string item in arr)
            {
                output.Add(item);
            }
        }

        static string[] ReadLines(string path)
        {
            string[] arr = File.ReadAllLines(path);

            return arr;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace _05.AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt");

            File.Delete("Output.txt");

            Dictionary<string, int> resaurseData = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i += 2)
            {
                if (input[i] == "stop")
                {
                    break;
                }

                string resaurse = input[i];
                int quantity = int.Parse(input[i + 1]);

                if (!resaurseData.ContainsKey(resaurse))
                {
                    resaurseData.Add(resaurse, 0);
                }
                resaurseData[resaurse] += quantity;
            }

            foreach (KeyValuePair<string, int> data in resaurseData)
            {
                string resaurse = data.Key;
                int quantity = data.Value;

                string output = $"{resaurse} -> {quantity}" + Environment.NewLine;

                File.AppendAllText("Output.txt", output);
            }
        }
    }
}

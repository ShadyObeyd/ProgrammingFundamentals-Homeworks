using System.Collections.Generic;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            string[] textLines = File.ReadAllLines("Input.txt");

            int cntr = 1;

            List<string> output = new List<string>();

            foreach (string line in textLines)
            {
                output.Add($"{cntr}. {line}");
                cntr++;
            }

            File.WriteAllLines("Output.txt", output);
        }
    }
}

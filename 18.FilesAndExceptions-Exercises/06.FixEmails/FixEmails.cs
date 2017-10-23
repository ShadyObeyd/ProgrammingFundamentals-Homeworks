using System;
using System.IO;

namespace _06.FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt");

            File.Delete("Output.txt");

            for (int i = 0; i < input.Length; i += 2)
            {
                if (input[i] == "stop")
                {
                    break;
                }

                string currentUser = input[i];
                string currentEmial = input[i + 1];

                if (currentEmial.EndsWith("us") || currentEmial.EndsWith("uk"))
                {
                    continue;
                }

                string output = $"{currentUser} -> {currentEmial}" + Environment.NewLine;

                File.AppendAllText("Output.txt", output);
            }
        }
    }
}

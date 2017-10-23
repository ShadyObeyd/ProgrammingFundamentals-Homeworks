using System;
using System.IO;

namespace _02.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string text = File.ReadAllText("Input.txt");

            File.Delete("Output.txt");

            foreach (char letter in text)
            {
                string output = $"{letter} -> {Array.IndexOf(alphabet, letter)}" + Environment.NewLine;

                File.AppendAllText("Output.txt", output);
            }
        }
    }
}

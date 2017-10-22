using System.IO;
using System.Linq;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            string[] textLines = File.ReadAllLines("Input.txt").Where((t, i) => i % 2 != 0).ToArray();

            File.WriteAllLines("Output.txt", textLines);
        }
    }
}

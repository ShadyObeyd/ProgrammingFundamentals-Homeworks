using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            Dictionary<string, int> resaurses = new Dictionary<string, int>();

            string input = Console.ReadLine();

            if (input == "stop")
            {
                return;
            }
            int quantty = int.Parse(Console.ReadLine());

            while (true)
            {
                if (!resaurses.ContainsKey(input))
                {
                    resaurses.Add(input, 0);
                }
                resaurses[input] += quantty;
                
                input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                quantty = int.Parse(Console.ReadLine());
            }

            foreach (KeyValuePair<string, int> resaurse in resaurses)
            {
                Console.WriteLine($"{resaurse.Key} -> {resaurse.Value}");
            }
        }
    }
}

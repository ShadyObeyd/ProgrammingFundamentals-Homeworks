using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int cntr = 0;

            while (true)
            {
                int num;
                if (int.TryParse(input, out num))
                {
                    cntr++;
                }
                else
                {
                    break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(cntr);
        }
    }
}

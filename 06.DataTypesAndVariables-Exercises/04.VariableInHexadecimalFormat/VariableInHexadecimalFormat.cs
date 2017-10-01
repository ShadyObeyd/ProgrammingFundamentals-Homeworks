using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int number = Convert.ToInt32(input, 16);

            Console.WriteLine(number);
        }
    }
}

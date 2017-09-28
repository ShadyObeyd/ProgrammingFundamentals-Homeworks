using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main()
        {
            string country = Console.ReadLine().ToLower();

            if (country == "usa" || country == "england")
            {
                Console.WriteLine("English");
            }
            else if (country == "spain" || country == "argentina" || country == "mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

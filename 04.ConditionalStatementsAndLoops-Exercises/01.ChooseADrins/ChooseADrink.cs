using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChooseADrins
{
    class ChooseADrink
    {
        static void Main()
        {
            string proffesion = Console.ReadLine().ToLower();

            if (proffesion == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (proffesion == "businessman" || proffesion == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (proffesion == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}

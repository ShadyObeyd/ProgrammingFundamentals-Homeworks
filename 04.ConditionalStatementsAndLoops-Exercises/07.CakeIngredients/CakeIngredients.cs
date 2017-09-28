using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            string command = Console.ReadLine();

            int cntr = 0;

            while (command != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {command}.");
                cntr++;
                command = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {cntr} ingredients.");
        }
    }
}

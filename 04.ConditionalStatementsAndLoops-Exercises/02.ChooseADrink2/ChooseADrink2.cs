using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main()
        {
            string proffession = Console.ReadLine();
            int drinkQuantity = int.Parse(Console.ReadLine());

            if (proffession == "Athlete")
            {
                Console.WriteLine($"The {proffession} has to pay {drinkQuantity * 0.7:f2}.");
            }
            else if (proffession == "Businessman" || proffession == "Businesswoman")
            {
                Console.WriteLine($"The {proffession} has to pay {drinkQuantity * 1.0:f2}.");
            }
            else if (proffession == "SoftUni Student")
            {
                Console.WriteLine($"The {proffession} has to pay {drinkQuantity * 1.7:f2}.");
            }
            else
            {
                Console.WriteLine($"The {proffession} has to pay {drinkQuantity * 1.2:f2}.");
            }
        }
    }
}

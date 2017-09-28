using System;

namespace _04.Beverage_Labels
{
    class BeverageLabels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");

            double totalEnergyContent = (volume / 100.0) * energyContent;
            double totalSugars = (volume / 100.0) * sugarContent;

            Console.WriteLine($"{totalEnergyContent}kcal, {totalSugars}g sugars");

        }
    }
}

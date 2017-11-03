using System;

namespace _01.CharityMarathon
{
    class CharityMarathon
    {
        static void Main()
        {
            long marathonLenght = long.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            long averageLaps = long.Parse(Console.ReadLine());
            long trackLenght = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long totalCapacity = trackCapacity * marathonLenght;

            if (numberOfRunners > totalCapacity)
            {
                numberOfRunners = totalCapacity;
            }

            decimal totalKm = (decimal)(numberOfRunners * averageLaps * trackLenght) / 1000;
            decimal totalMoneyRaised = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoneyRaised:f2}");
        }
    }
}

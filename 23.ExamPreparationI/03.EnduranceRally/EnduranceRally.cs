using System;
using System.Linq;

namespace _03.EnduranceRally
{
    class EnduranceRally
    {
        static void Main()
        {
            string[] racerNames = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] zones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < racerNames.Length; i++)
            {
                string currentRacer = racerNames[i];
                double currentFuel = currentRacer.First();
                int endIndex = 0;

                for (int j = 0; j < zones.Length; j++)
                {
                    double currentZone = zones[j];

                    if (checkpoints.Contains(j))
                    {
                        currentFuel += currentZone;
                    }
                    else
                    {
                        currentFuel -= currentZone;
                    }

                    if (currentFuel <= 0)
                    {
                        endIndex = j;
                        break;
                    }
                }

                if (currentFuel <= 0)
                {
                    Console.WriteLine($"{currentRacer} - reached {endIndex}");
                }
                else
                {
                    Console.WriteLine($"{currentRacer} - fuel left {currentFuel:f2}");
                }

            }
        }
    }
}

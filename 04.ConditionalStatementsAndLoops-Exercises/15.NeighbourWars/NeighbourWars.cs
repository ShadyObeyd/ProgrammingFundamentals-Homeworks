using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class NeighbourWars
    {
        static void Main()
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());

            int peshoHP = 100;
            int goshoHP = 100;

            int cntr = 1;

            while (true)
            {
                if (cntr % 2 == 0)
                {
                    peshoHP -= goshoDmg;

                    if (peshoHP <= 0)
                    {
                        Console.WriteLine($"Gosho won in {cntr}th round.");
                        break;
                    }
                    else if (goshoHP <= 0)
                    {
                        Console.WriteLine($"Pesho won in {cntr}th round.");
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHP} health.");
                }
                else if (cntr % 2 == 1)
                {
                    goshoHP -= peshoDmg;

                    if (peshoHP <= 0)
                    {
                        Console.WriteLine($"Gosho won in {cntr}th round.");
                        break;
                    }
                    else if (goshoHP <= 0)
                    {
                        Console.WriteLine($"Pesho won in {cntr}th round.");
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHP} health.");
                }

                if (cntr % 3 == 0)
                {
                    peshoHP += 10;
                    goshoHP += 10;
                }
                cntr++;
            }
        }
    }
}

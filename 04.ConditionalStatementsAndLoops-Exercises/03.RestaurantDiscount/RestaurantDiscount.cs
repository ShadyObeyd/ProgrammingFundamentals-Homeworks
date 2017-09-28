using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            double pricePerPerson = 0.0;

            if (groupSize <= 50)
            {
                if (package == "normal")
                {
                    pricePerPerson = 2850.0 / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "gold")
                {
                    pricePerPerson = 2925.0 / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "platinum")
                {
                    pricePerPerson = 2975.0 / groupSize;
                    Console.WriteLine("We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                if (package == "normal")
                {
                    pricePerPerson = 5225.0 / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "gold")
                {
                    pricePerPerson = 5175.0 / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "platinum")
                {
                    pricePerPerson = 5100.0 / groupSize;
                    Console.WriteLine("We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                if (package == "normal")
                {
                    pricePerPerson = 7600.0 / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "gold")
                {
                    pricePerPerson = 7425.0 / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (package == "platinum")
                {
                    pricePerPerson = 7225.0 / groupSize;
                    Console.WriteLine("We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}

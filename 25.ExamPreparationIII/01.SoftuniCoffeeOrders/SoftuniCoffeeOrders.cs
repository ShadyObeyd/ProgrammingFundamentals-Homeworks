using System;
using System.Globalization;

namespace _01.SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());

                int daysInMont = GetDaysInMonth(orderDate);

                decimal price = ((decimal)daysInMont * capsulesCount) * capsulePrice;

                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }

        private static int GetDaysInMonth(DateTime orderDate)
        {
            return DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
        }
    }
}

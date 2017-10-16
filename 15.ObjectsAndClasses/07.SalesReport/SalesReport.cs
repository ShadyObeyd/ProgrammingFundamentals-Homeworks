using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class SalesReport
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

                string town = tokens[0];
                string product = tokens[1];
                decimal price = decimal.Parse(tokens[2]);
                decimal quantity = decimal.Parse(tokens[3]);

                Sale sale = new Sale(town, product, price, quantity);

                sales.Add(sale);
            }

            List<string> towns = sales
                .Select(s => s.Town)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            foreach (string town in towns)
            {
                decimal sum =
                    sales
                    .Where(s => s.Town == town)
                    .Select(s => s.Price * s.Quantity)
                    .Sum();

                Console.WriteLine($"{town} -> {sum:f2}");
            }
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public Sale (string town, string product, decimal price, decimal quantity)
        {
            this.Town = town;
            this.Product = product;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}

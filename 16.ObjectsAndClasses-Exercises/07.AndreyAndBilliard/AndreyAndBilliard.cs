using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }

    class AndreyAndBilliard
    {
        static void Main()
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());

            LoadTheShop(n, shop);


            string input = Console.ReadLine();

            List<Customer> customers = new List<Customer>();

            while (input != "end of clients")
            {
                Dictionary<string, int> shopList = new Dictionary<string, int>();

                string[] tokens = input.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string clientName = tokens[0];
                string product = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (shop.ContainsKey(product))
                {
                    if (!shopList.ContainsKey(product))
                    {
                        shopList.Add(product, 0);
                    }
                    shopList[product] = quantity;

                    Customer customer = new Customer();
                    customer.ShopList = shopList;
                    customer.Name = clientName;

                    if (customers.Any(c => c.Name == clientName))
                    {
                        Customer existingCustomer = customers.First(c => c.Name == clientName);

                        if (existingCustomer.ShopList.ContainsKey(product))
                        {
                            existingCustomer.ShopList[product] += quantity;
                        }
                        else
                        {
                            existingCustomer.ShopList[product] = quantity;
                        }
                    }
                    else
                    {
                        customers.Add(customer);
                    }
                }
                
                input = Console.ReadLine();
            }

            CreateBill(customers, shop);

            foreach (Customer customer in customers.OrderBy(x => x.Name))
            {
                string customerName = customer.Name;
                Dictionary<string, int> shopList = customer.ShopList;
                decimal bill = customer.Bill;

                Console.WriteLine(customerName);

                foreach (KeyValuePair<string, int> sh in shopList)
                {
                    string product = sh.Key;
                    int quantity = sh.Value;

                    Console.WriteLine($"-- {product} - {quantity}");
                }

                Console.WriteLine($"Bill: {bill:f2}");
            }

            Console.WriteLine($"Total bill: {customers.Sum(x => x.Bill):f2}");
        }

        private static void CreateBill(List<Customer> customers, Dictionary<string, decimal> shop)
        {
            foreach (Customer customer in customers)
            {
                string name = customer.Name;
                Dictionary<string, int> shopList = customer.ShopList;

                foreach (KeyValuePair<string, int> sh in shopList)
                {
                    string product = sh.Key;
                    int quantity = sh.Value;

                    foreach (KeyValuePair<string, decimal> s in shop)
                    {
                        string productt = s.Key;
                        decimal price = s.Value;

                        if (product == productt)
                        {
                            customer.Bill += price * quantity;
                        }
                    }
                }
            }
        }

        private static void LoadTheShop(int n, Dictionary<string, decimal> shop)
        {
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                if (!shop.ContainsKey(product))
                {
                    shop.Add(product, 0);
                }
                shop[product] = price;
            }
        }
    }
}

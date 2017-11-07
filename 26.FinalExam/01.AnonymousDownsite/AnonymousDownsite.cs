using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.AnonymousDownsite
{
    class AnonymousDownsite
    {
        static void Main()
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());

            decimal totlaLoss = 0;

            for (int i = 0; i < n; i++)
            {
                string[] websitesData = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string siteName = websitesData[0];
                long siteVisits = long.Parse(websitesData[1]);
                decimal pricePerVisit = decimal.Parse(websitesData[2]);

                Console.WriteLine(siteName);

                decimal currentLoss = siteVisits * pricePerVisit;

                totlaLoss += currentLoss;
            }

            Console.WriteLine($"Total Loss: {totlaLoss:f20}");

            BigInteger securityToken = 1;

            for (int i = 0; i < n; i++)
            {
                securityToken *= securityKey;
            }

            

            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}

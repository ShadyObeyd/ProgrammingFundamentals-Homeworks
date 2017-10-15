using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10.SerbianUnleashed
{
    class SerbianUnleashed
    {
        static void Main()
        {
            Regex pattern = new Regex(@"^(?<singer>[A-Za-z ]*) @(?<venue>[A-Za-z ]*) (?<tickerPrice>[\d]+) (?<ticketsCount>[\d]+)$");

            var concertData = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);

                    string singer = match.Groups["singer"].Value;
                    string venue = match.Groups["venue"].Value;
                    long tickerPrice = long.Parse(match.Groups["tickerPrice"].Value);
                    long ticketCount = long.Parse(match.Groups["ticketsCount"].Value);

                    if (!concertData.ContainsKey(venue))
                    {
                        concertData.Add(venue, new Dictionary<string, long>());
                    }

                    if (!concertData[venue].ContainsKey(singer))
                    {
                        concertData[venue].Add(singer, 0);
                    }
                    concertData[venue][singer] += tickerPrice * ticketCount;
                }
                input = Console.ReadLine();
            }

            foreach (var data in concertData)
            {
                string venue = data.Key;
                Dictionary<string, long> venueData = data.Value;

                Console.WriteLine(venue);

                foreach (KeyValuePair<string, long> concert in venueData.OrderByDescending(v => v.Value))
                {
                    string singer = concert.Key;
                    long moneyMade = concert.Value;

                    Console.WriteLine($"#  {singer} -> {moneyMade}");
                }
            }
        }
    }
}

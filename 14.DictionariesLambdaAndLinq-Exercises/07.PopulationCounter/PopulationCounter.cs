using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class PopulationCounter
    {
        static void Main()
        {
            var populationData = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] tokens = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string city = tokens[0];
                string country = tokens[1];
                long population = long.Parse(tokens[2]);

                if (!populationData.ContainsKey(country))
                {
                    populationData.Add(country, new Dictionary<string, long>());
                }

                if (!populationData[country].ContainsKey(city))
                {
                    populationData[country].Add(city, 0);
                }
                populationData[country][city] = population;

                input = Console.ReadLine();
            }

            foreach (var statistics in populationData.OrderByDescending(v => v.Value.Values.Sum()))
            {
                string country = statistics.Key;
                Dictionary<string, long> cityData = statistics.Value;

                Console.WriteLine($"{country} (total population: {cityData.Values.Sum()})");

                foreach (KeyValuePair<string, long> data in cityData.OrderByDescending(v => v.Value))
                {
                    string city = data.Key;
                    long population = data.Value;

                    Console.WriteLine($"=>{city}: {population}");
                }
            }
        }
    }
}

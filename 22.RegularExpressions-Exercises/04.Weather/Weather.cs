using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class CityForcast
    {
        public double AverageTemp { get; set; }
        public string Weather { get; set; }

        public CityForcast(double averageTemp, string weather)
        {
            this.AverageTemp = averageTemp;
            this.Weather = weather;
        }
    }
    class Weather
    {
        static void Main()
        {
            Dictionary<string, CityForcast> forcastData = new Dictionary<string, CityForcast>();

            Regex pattern = new Regex(@"(?<cityName>[A-Z]{2})(?<temp>[\d]+\.[\d]+)(?<weather>[A-Za-z]+)(?=\|)");

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (pattern.IsMatch(input))
                {
                    Match forcast = pattern.Match(input);

                    string cityName = forcast.Groups["cityName"].Value;
                    double averageTemp = double.Parse(forcast.Groups["temp"].Value);
                    string weather = forcast.Groups["weather"].Value;

                    if (!forcastData.ContainsKey(cityName))
                    {
                        forcastData.Add(cityName, new CityForcast(averageTemp, weather));
                    }
                    forcastData[cityName] = new CityForcast(averageTemp, weather);
                }
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, CityForcast> data in forcastData.OrderBy(t => t.Value.AverageTemp))
            {
                string cityName = data.Key;
                CityForcast forcast = data.Value;

                Console.WriteLine($"{cityName} => {forcast.AverageTemp:f2} => {forcast.Weather}");
            }
        }
    }
}

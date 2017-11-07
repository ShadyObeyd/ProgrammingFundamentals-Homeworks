using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AnonymousCache
{
    class AnonymousCache
    {
        static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "thetinggoesskrra")
            {
                string[] tokens = input.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 1)
                {
                    string dataSet = tokens[0];

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());

                        if (cache.ContainsKey(dataSet))
                        {
                            data[dataSet] = cache[dataSet];
                        }
                    }
                }
                else
                {
                    string dataKey = tokens[0];
                    long dataSize = long.Parse(tokens[1]);
                    string dataSet = tokens[2];

                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, long>());
                        }
                        cache[dataSet].Add(dataKey, dataSize);
                    }
                }
                input = Console.ReadLine();
            }

            data =
                data
                .OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(k => k.Key, v => v.Value);

            int cnt = 0;
            foreach (var item in data)
            {
                if (cnt >= 1)
                {
                    break;
                }
                string dataSet = item.Key;
                Dictionary<string, long> dataValues = item.Value;

                Console.WriteLine($"Data Set: {dataSet}, Total Size: {dataValues.Values.Sum()}");

                foreach (KeyValuePair<string, long> values in dataValues)
                {
                    string dataKey = values.Key;
                    long dataSize = values.Value;

                    Console.WriteLine($"$.{dataKey}");
                }
                cnt++;
            }
        }
    }
}

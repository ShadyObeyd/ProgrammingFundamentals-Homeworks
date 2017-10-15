using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAgregator
{
    class LogsAgregator
    {
        class Logs
        {
            public int Durations { get; set; }
            public List<string> Ips { get; set; }
        }

        static void Main()
        {
            SortedDictionary<string, Logs> logsData = new SortedDictionary<string, Logs>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string ipAddress = tokens[0];
                string user = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (!logsData.ContainsKey(user))
                {
                    logsData.Add(user, new Logs
                    {
                        Durations = 0,
                        Ips = new List<string>()
                    });
                }
                logsData[user].Durations += duration;
                logsData[user].Ips.Add(ipAddress);
            }

            foreach (KeyValuePair<string, Logs> data in logsData)
            {
                string user = data.Key;
                Logs logs = data.Value;

                logs.Ips = logs.Ips.Distinct().ToList();
                logs.Ips.Sort();

                Console.WriteLine($"{user}: {logs.Durations} [{string.Join(", ", logs.Ips)}]");
            }
        }
    }
}

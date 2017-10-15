using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class UserLogs
    {
        static void Main()
        {
            var data = new SortedDictionary<string, Dictionary<string, List<string>>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string ipAddress = tokens[0].Replace("IP=", "");
                string message = tokens[1];
                string user = tokens[2].Replace("user=", "");

                if (!data.ContainsKey(user))
                {
                    data.Add(user, new Dictionary<string, List<string>>());
                }

                if (!data[user].ContainsKey(ipAddress))
                {
                    data[user].Add(ipAddress, new List<string>());
                }
                data[user][ipAddress].Add(message);


                input = Console.ReadLine();
            }

            foreach (var inputs in data)
            {
                string user = inputs.Key;
                Dictionary<string, List<string>> datas = inputs.Value;

                Console.WriteLine($"{user}:");
                List<string> result = new List<string>();
                foreach (KeyValuePair<string, List<string>> users in datas)
                {
                    string ip = users.Key;
                    List<string> messages = users.Value;

                    string output = $"{ip} => {messages.Count}";

                    result.Add(output);
                }

                Console.WriteLine(string.Join(", ", result) + ".");
            }
        }
    }
}

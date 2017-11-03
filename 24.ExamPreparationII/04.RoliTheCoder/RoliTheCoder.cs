using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RoliTheCoder
{
    class RoliTheCoder
    {
        static void Main()
        {
            var data = new Dictionary<int, Dictionary<string, List<string>>>();

            string input = Console.ReadLine();

            while (input != "Time for Code")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToArray();

                int id = int.Parse(tokens[0]);
                string eventt = tokens[1];

                if (eventt.StartsWith("#"))
                {
                    eventt = eventt.Remove(0, 1);

                    if (!data.ContainsKey(id))
                    {
                        data.Add(id, new Dictionary<string, List<string>>());

                        if (!data[id].ContainsKey(eventt))
                        {
                            data[id].Add(eventt, new List<string>());
                            AddParticipants(tokens, data[id][eventt]);
                        }
                    }

                    if (data[id].ContainsKey(eventt))
                    {
                        AddParticipants(tokens, data[id][eventt]);
                    }


                }

                input = Console.ReadLine();
            }

            foreach (var eventData in data.OrderByDescending(p => p.Value.Values.Sum(v => v.Count)).ThenBy(n => n.Key))
            {
                Dictionary<string, List<string>> events = eventData.Value;

                foreach (var item in events)
                {
                    string eventt = item.Key;
                    List<string> participants = item.Value;

                    Console.WriteLine($"{eventt} - {participants.Count}");

                    foreach (string p in participants.OrderBy(p => p))
                    {
                        Console.WriteLine(p);
                    }

                }
            }
        }

        private static void AddParticipants(string[] tokens, List<string> list)
        {
            for (int i = 2; i < tokens.Length; i++)
            {

                if (tokens[i].StartsWith("@"))
                {
                    if (!list.Contains(tokens[i]))
                    {
                        list.Add(tokens[i]);
                    }
                }
            }
        }
    }
}

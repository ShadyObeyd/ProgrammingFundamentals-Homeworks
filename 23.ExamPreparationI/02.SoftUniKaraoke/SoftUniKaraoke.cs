using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main()
        {
            Dictionary<string, List<string>> awardsData = new Dictionary<string, List<string>>();

            string[] participants = ReadInput(Console.ReadLine());
            string[] songs = ReadInput(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "dawn")
            {
                string[] karaokeTokens = ReadInput(input);

                string participant = karaokeTokens[0];
                string song = karaokeTokens[1];
                string award = karaokeTokens[2];

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!awardsData.ContainsKey(participant))
                    {
                        awardsData.Add(participant, new List<string>());
                    }

                    if (!awardsData[participant].Contains(award))
                    {
                        awardsData[participant].Add(award);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var data in awardsData.OrderByDescending(a => a.Value.Count()).ThenBy(p => p.Key))
            {
                string participant = data.Key;
                List<string> awards = data.Value;

                Console.WriteLine($"{participant}: {awards.Count()} awards");

                foreach (string award in awards.OrderBy(n => n))
                {
                    Console.WriteLine($"--{award}");
                }
            }

            if (awardsData.Count() == 0)
            {
                Console.WriteLine("No awards");
            }
        }
        
        static string[] ReadInput(string str)
        {
            return str.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

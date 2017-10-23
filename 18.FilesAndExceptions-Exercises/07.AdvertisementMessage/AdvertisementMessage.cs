using System;
using System.IO;

namespace _07.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main()
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(File.ReadAllText("Input.txt"));

            File.Delete("Output.txt");

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int phraseIndex = rnd.Next(0, phrases.Length);
                int eventIndex = rnd.Next(0, events.Length);
                int authorIndex = rnd.Next(0, authors.Length);
                int cityIndex = rnd.Next(0, cities.Length);

                string message = $"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[cityIndex]}" + Environment.NewLine;

                File.AppendAllText("Output.txt", message);
            }
        }
    }
}

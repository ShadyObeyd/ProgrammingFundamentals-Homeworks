using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class HandsOfCards
    {
        static void Main()
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] tokens = input.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string[] cards = tokens[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                List<int> poweredCards = new List<int>();
                for (int i = 0; i < cards.Length; i++)
                {
                    string currentCard = cards[i];

                    int currentValue = GetCurrentValue(currentCard);
                    poweredCards.Add(currentValue);
                }

                if (!data.ContainsKey(name))
                {
                    data.Add(name, new List<int>());
                }
                
                data[name].AddRange(poweredCards);
    
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<int>> players in data)
            {
                string name = players.Key;
                List<int> cards = players.Value.Distinct().ToList();
            
                Console.WriteLine($"{name}: {cards.Sum()}");
            }
        }

        private static int GetCurrentValue(string currentCard)
        {
            int power = 0;
            int type = 0;

            for (int i = 0; i < currentCard.Length; i++)
            {
                char currentSymbol = currentCard[i];

                if (currentCard.Length == 2)
                {
                    if (char.IsDigit(currentSymbol))
                    {
                        power = currentSymbol - '0';
                    }
                }
                else
                {
                    power = 10;
                }

                if (currentSymbol == 'S')
                {
                    type = 4;
                }
                else if (currentSymbol == 'H')
                {
                    type = 3;
                }
                else if (currentSymbol == 'D')
                {
                    type = 2;
                }
                else if (currentSymbol == 'C')
                {
                    type = 1;
                }
                else if (currentSymbol == 'J')
                {
                    power = 11;
                }
                else if (currentSymbol == 'Q')
                {
                    power = 12;
                }
                else if (currentSymbol == 'K')
                {
                    power = 13;
                }
                else if (currentSymbol == 'A')
                {
                    power = 14;
                }
            }

            return power * type;
        }
    }
}

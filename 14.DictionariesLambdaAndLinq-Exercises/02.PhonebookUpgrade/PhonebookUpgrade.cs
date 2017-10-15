using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "A")
                {
                    string contactName = tokens[1];
                    string phoneNumber = tokens[2];

                    if (!phonebook.ContainsKey(contactName))
                    {
                        phonebook.Add(contactName, phoneNumber);
                    }
                    phonebook[contactName] = phoneNumber;
                }
                else if (tokens[0] == "S")
                {
                    string contactName = tokens[1];

                    if (phonebook.ContainsKey(contactName))
                    {
                        Console.WriteLine($"{contactName} -> {phonebook[contactName]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {contactName} does not exist.");
                    }
                }
                else if (tokens[0] == "ListAll")
                {
                    PrintPhonebook(phonebook);
                }

                input = Console.ReadLine();
            }
        }

        private static void PrintPhonebook(SortedDictionary<string, string> phonebook)
        {
            foreach (KeyValuePair<string, string> contacts in phonebook)
            {
                string contactName = contacts.Key;
                string phoneNumber = contacts.Value;

                Console.WriteLine($"{contactName} -> {phoneNumber}");
            }
        }
    }
}

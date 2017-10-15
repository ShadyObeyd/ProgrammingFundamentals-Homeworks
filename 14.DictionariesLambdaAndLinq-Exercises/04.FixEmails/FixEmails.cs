using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();

            string nameInput = Console.ReadLine();

            if (nameInput == "stop")
            {
                return;
            }
            string emailInput = Console.ReadLine();

            while (true)
            {
                if (!emails.ContainsKey(nameInput))
                {
                    emails.Add(nameInput, emailInput);
                }
                nameInput = Console.ReadLine();

                if (nameInput == "stop")
                {
                    break;
                }

                emailInput = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> mail in emails)
            {
                string name = mail.Key;
                string email = mail.Value;

                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    Console.WriteLine($"{name} -> {email}");
                }
            }
        }
    }
}

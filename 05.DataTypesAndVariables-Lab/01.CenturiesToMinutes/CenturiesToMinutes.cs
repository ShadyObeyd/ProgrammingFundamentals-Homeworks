using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main()
        {
            int centuriesCntr = int.Parse(Console.ReadLine());

            int years = centuriesCntr * 100;
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{centuriesCntr} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}

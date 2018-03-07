
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            var destination = "";
            var typ = "";
            var total = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    typ = "Camp";
                    total = 0.3 * budget;
                }
                else if (season == "winter")
                {
                    typ = "Hotel";
                    total = 0.70 * budget;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    typ = "Camp";
                    total = 0.40 * budget;
                }
                else if (season == "winter")
                {
                    typ = "Hotel";
                    total = 0.80 * budget;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                typ = "Hotel";
                total = 0.90 * budget;
            }
            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", typ, total);
        }
    }
}

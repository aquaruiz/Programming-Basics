using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            var price = 0.0;
            var place = "";
            var home = "";

            if (budget <= 1000)
            {
                home = "Camp";
                if (season == "summer")
                {
                    place = "Alaska";
                    price = 0.65 * budget;
                }
                else if (season == "winter")
                {
                    place = "Morocco";
                    price = 0.45 * budget;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                home = "Hut";
                if (season == "summer")
                {
                    place = "Alaska";
                    price = 0.80 * budget;
                }
                else if (season == "winter")
                {
                    place = "Morocco";
                    price = 0.60 * budget;
                }
            }
            else if (budget > 3000)
            {
                home = "Hotel";
                price = 0.90 * budget;
                if (season == "summer")
                {
                    place = "Alaska";
                }
                else if (season == "winter")
                {
                    place = "Morocco";
                }
            }

            Console.WriteLine($"{place} - {home} - {price:f2}");
        }
    }
}

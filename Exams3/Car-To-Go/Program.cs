using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            var price = 0.0;
            var carClass = "";
            var car = "";

            if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "summer")
                {
                    car = "Cabrio";
                    price = 0.35 * budget;
                }
                else if (season == "winter")
                {
                    car = "Jeep";
                    price = 0.65 * budget;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                carClass = "Compact class";
                if (season == "summer")
                {
                    car = "Cabrio";
                    price = 0.45 * budget;
                }
                else if (season == "winter")
                {
                    car = "Jeep";
                    price = 0.80 * budget;
                }
            }
            else if (budget > 500)
            {
                carClass = "Luxury class";
                price = 0.90 * budget;
                car = "Jeep";
            }

            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{car} - {price:f2}");
        }
    }
}

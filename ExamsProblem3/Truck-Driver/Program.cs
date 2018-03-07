using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var kmPerMonth = int.Parse(Console.ReadLine());

            var total = 0.0;

            if (kmPerMonth <= 5000)
            {
                if (season == "spring" || season == "autumn")
                    total = 0.75;
                if (season == "summer")
                    total = 0.90;
                if (season == "winter")
                    total = 1.05;
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == "spring" || season == "autumn")
                    total = 0.95;
                if (season == "summer")
                    total = 1.10;
                if (season == "winter")
                    total = 1.25;
            }
            else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                total = 1.45;

            total = total * kmPerMonth * 4 * (1 - 0.1);

            Console.WriteLine("{0:f2}", total);
        }
    }
}

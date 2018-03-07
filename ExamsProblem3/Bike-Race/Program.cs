using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniorRacers = int.Parse(Console.ReadLine());
            var seniorRacers = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine().ToLower();

            var charity = 0.0;

            if (trace == "trail")
                charity = juniorRacers * 5.50 + seniorRacers * 7;
            else if (trace == "cross-country")
                charity = juniorRacers * 8 + seniorRacers * 9.50;
            else if (trace == "downhill")
                charity = juniorRacers * 12.25 + seniorRacers * 13.75;
            else if (trace == "road")
                charity = juniorRacers * 20 + seniorRacers * 21.50;

            if (trace == "cross-country" && (juniorRacers + seniorRacers) >= 50)
                charity -= 0.25 * charity;

            charity -= 0.05 * charity;

            Console.WriteLine($"{charity:f2}");

        }
    }
}

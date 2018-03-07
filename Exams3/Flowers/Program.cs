using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var flower1 = int.Parse(Console.ReadLine());
            var flower2 = int.Parse(Console.ReadLine());
            var flower3 = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var holiday = Console.ReadLine().ToLower();

            var price = 0.0;

            if (season == "spring" || season == "summer")
            {
                price = flower1 * 2 + flower2 * 4.10 + flower3 * 2.50;
            }
            else if (season == "autumn" || season == "winter")
            {
                price = flower1 * 3.75 + flower2 * 4.50 + flower3 * 4.15;
            }

            if (holiday == "y")
                price += 0.15 * price;

            if (flower3 > 7 && season == "spring")
                price -= 0.05 * price;
            if (flower2 >= 10 && season == "winter")
                price -= 0.1 * price;
            if ((flower1 + flower2 + flower3) > 20)
                price -= 0.2 * price;

            price += 2;

            Console.WriteLine($"{price:f2}");
            {

            }
        }
    }
}

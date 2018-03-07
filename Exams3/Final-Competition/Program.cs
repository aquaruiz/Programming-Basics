using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dancers = int.Parse(Console.ReadLine());
            var points = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var place = Console.ReadLine().ToLower();

            var price = 0.0;

            if (place == "bulgaria")
            {
                price = points * dancers;
                if (season == "summer")
                    price -= 0.05 * price;
                else if (season == "winter")
                    price -= 0.08 * price;
            }
            else if (place == "abroad")
            {
                price = points * dancers * (1 + 0.5);
                if (season == "summer")
                    price -= 0.10 * price;
                else if (season == "winter")
                    price -= 0.15 * price;
            }

            var charity = 0.75 * price;
            var perDancer = (0.25 * price) / dancers;

            Console.WriteLine("Charity - {0:f2}", charity);
            Console.WriteLine("Money per dancer - {0:f2}",perDancer);
        }
    }
}

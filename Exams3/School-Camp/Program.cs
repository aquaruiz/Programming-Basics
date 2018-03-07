using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var groupType = Console.ReadLine().ToLower();
            var studentsQnty = int.Parse(Console.ReadLine());
            var overnightsQnty = int.Parse(Console.ReadLine());

            var sport = "";
            var price = 0.0;

            if (groupType == "boys")
            {
                if (season == "winter")
                {
                    price = 9.60;
                    sport = "Judo";
                }
                else if (season == "spring")
                {
                    price = 7.20;
                    sport = "Tennis";
                }
                else if (season == "summer")
                {
                    price = 15;
                    sport = "Football";
                }
            }
            else if (groupType == "girls")
            {
                if (season == "winter")
                {
                    price = 9.60;
                    sport = "Gymnastics";
                }
                else if (season == "spring")
                {
                    price = 7.20;
                    sport = "Athletics";
                }
                else if (season == "summer")
                {
                    price = 15;
                    sport = "Volleyball";
                }
            }
            else if (groupType == "mixed")
            {
                if (season == "winter")
                {
                    price = 10;
                    sport = "Ski";
                }
                else if (season == "spring")
                {
                    price = 9.50;
                    sport = "Cycling";
                }
                else if (season == "summer")
                {
                    price = 20;
                    sport = "Swimming";
                }
            }

            price = price * overnightsQnty * studentsQnty;

            if (studentsQnty >= 50)
                price -= 0.5 * price;
            else if (studentsQnty >= 20 && studentsQnty < 50)
                price -= 0.15 * price;
            else if (studentsQnty >= 10 && studentsQnty < 20)
                price -= 0.05 * price;

            Console.WriteLine("{0} {1:f2} lv.", sport, price);
        }
    }
}

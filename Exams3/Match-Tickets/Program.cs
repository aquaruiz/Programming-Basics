using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var people = int.Parse(Console.ReadLine());

            var transportationCosts = 0.0;
            var price = 0.0;

            if (people >= 1 && people <= 4)
                transportationCosts = 0.75 * budget;
            else if (people >= 5 && people <= 9)
                transportationCosts = 0.60 * budget;
            else if (people >= 10 && people <= 24)
                transportationCosts = 0.50 * budget;
            else if (people >= 25 && people <= 49)
                transportationCosts = 0.40 * budget;
            else if (people >= 50)
                transportationCosts = 0.25 * budget;

            budget -= transportationCosts;

            if (category == "vip")
                price = people * 499.99;
            else if (category == "normal")
                price = people * 249.99;

            if (budget >= price)
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - price);
            else
                Console.WriteLine("Not enough money! You need {0:f2} leva.", price - budget);

        }
    }
}

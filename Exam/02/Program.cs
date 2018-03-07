using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestQnty = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int guestPrice = 20;
            int totalGuestsPrice = guestPrice * guestQnty;

            int budgetLeft = budget - totalGuestsPrice;

            if (budget >= totalGuestsPrice)
            {
                double fireworksMoney = 0.4 * budgetLeft;
                double charityMoney = budgetLeft - fireworksMoney;
                Console.WriteLine("Yes! {0:f0} lv are for fireworks and {1:f0} lv are for donation.", fireworksMoney, charityMoney);
            }
            else if(totalGuestsPrice > budget)
            {
                Console.WriteLine("They won't have enough money to pay the covert. They will need {0:f0} lv more.", totalGuestsPrice - budget);
            }
        }
    }
}

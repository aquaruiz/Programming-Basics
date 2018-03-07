using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripPrice = double.Parse(Console.ReadLine());
            var puzzels = int.Parse(Console.ReadLine());
            var dolls = int.Parse(Console.ReadLine());
            var teddyBears = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var trucks = int.Parse(Console.ReadLine());

            var totalToysQnty = puzzels + dolls + teddyBears + minions + trucks;
            var totalPrice = puzzels * 2.6 + dolls * 3 + teddyBears * 4.1 + minions * 8.2 + trucks * 2;

            if (totalToysQnty >= 50)
            {
                totalPrice = totalPrice - 0.25 * totalPrice;
            }

            var finalPrice = totalPrice - 0.1 * totalPrice;

            if (finalPrice >= tripPrice)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", finalPrice - tripPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", tripPrice - finalPrice);
            }
        }
    }
}

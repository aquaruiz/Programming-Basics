using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washingMashinePrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var money = 0.0;
            var price = 10;
            var toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += price;
                    price += 10;
                    money--;
                }
                else
                {
                    toys++;
                }
            }

            var totalMoney = money + toys * toyPrice;

            if (totalMoney >= washingMashinePrice)
                Console.WriteLine("Yes! {0:0.00}", totalMoney - washingMashinePrice);
            else
                Console.WriteLine("No! {0:0.00}", washingMashinePrice - totalMoney);
            {

            }
        }
    }
}

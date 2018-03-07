using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = double.Parse(Console.ReadLine());
            var typ = Console.ReadLine().ToLower();
            var distance = int.Parse(Console.ReadLine());

            var price = 0.0;

            if (weight < 1)
                price = 0.03;
            else if (weight >= 1 && weight <= 10)
                price = 0.05;
            else if (weight >= 11 && weight <= 40)
                price = 0.10;
            else if (weight >= 41 && weight <= 90)
                price = 0.15;
            else if (weight >= 91 && weight <= 150)
                price = 0.20;

            if (typ == "express")
            {
                if (weight < 1)
                    price += 0.8 * 0.03* weight;
                else if (weight >= 1 && weight <= 10)
                    price += 0.4 * 0.05 * weight;
                else if (weight >= 11 && weight <= 40)
                    price += 0.05 * 0.10 * weight;
                else if (weight >= 41 && weight <= 90)
                    price += 0.02 * 0.15 * weight;
                else if (weight >= 91 && weight <= 150)
                    price += 0.01 * 0.20 * weight;
            }

            var totalPrice = price * distance;

            Console.WriteLine("The delivery of your shipment with weight of {0:f3} kg. would cost {1:f2} lv.", weight, totalPrice);
        }
    }
}

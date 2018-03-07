using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Cocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var size = Console.ReadLine().ToLower();
            var qnty = int.Parse(Console.ReadLine());

            var price = 0.0;

            if (size == "small")
            {
                if (fruit == "watermelon")
                    price = 56;
                else if (fruit == "mango")
                    price = 36.66;
                else if (fruit == "pineapple")
                    price = 42.10;
                else if (fruit == "raspberry")
                    price = 20;
                price = price * qnty * 2;
            }
            else if (size == "big")
            {
                if (fruit == "watermelon")
                    price = 28.70;
                else if (fruit == "mango")
                    price = 19.60;
                else if (fruit == "pineapple")
                    price = 24.80;
                else if (fruit == "raspberry")
                    price = 15.20;
                price = price * qnty * 5;
            }

            if (price > 1000)
            {
                price -= 0.5 * price;
            }
            else if (price >= 400 && price <= 1000)
            {
                price -= 0.15 * price;
            }

            Console.WriteLine("{0:f2} lv.", price);
        }
    }
}

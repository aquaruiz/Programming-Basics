using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int overnight = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine().ToLower();
            string transport = Console.ReadLine().ToLower();

            double adultPrice = 0.0;
            double kidPrice = 0.0;

            if (destination == "miami")
            {
                if (overnight <= 10)
                {
                    adultPrice = 24.99;
                    kidPrice = 14.99;
                }
                else if (overnight <= 15)
                {
                    adultPrice = 22.99;
                    kidPrice = 11.99;
                }
                else if (overnight > 15)
                {
                    adultPrice = 20.00;
                    kidPrice = 10.00;
                }
            }
            else if (destination == "canary islands")
            {
                if (overnight <= 10)
                {
                    adultPrice = 32.50;
                    kidPrice = 28.50;
                }
                else if (overnight <= 15)
                {
                    adultPrice = 30.50;
                    kidPrice = 25.60;
                }
                else if (overnight > 15)
                {
                    adultPrice = 28.00;
                    kidPrice = 22.00;
                }
            }
            else if (destination == "philippines")
            {
                if (overnight <= 10)
                {
                    adultPrice = 42.99;
                    kidPrice = 39.99;
                }
                else if (overnight <= 15)
                {
                    adultPrice = 41.00;
                    kidPrice = 36.00;
                }
                else if (overnight > 15)
                {
                    adultPrice = 38.50;
                    kidPrice = 32.40;
                }
            }  
            
            double totalPrice = (2 * adultPrice + 3 * kidPrice) * overnight;
            double dogPrice = 0.25 * totalPrice;

            if (transport == "train")
            {
                adultPrice = 22.30;
                kidPrice = 12.50;
            }
            else if (transport == "bus")
            {
                adultPrice = 45.00;
                kidPrice = 37.00;
            }
            else if (transport == "airplane")
            {
                adultPrice = 90.00;
                kidPrice = 68.50;
            }

            double transportPrice = 2 * adultPrice + 3 * kidPrice;
            double endPrice = totalPrice + dogPrice + transportPrice;

            Console.WriteLine("{0:f3}", endPrice);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_to_the_past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var age = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    money -= 12000;
                }
                else
                {
                    money -= 12000 + 50 * age; 
                }
                age++;
            }

            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:0.00} dollars left.", money);
            }
            else
            {
                Console.WriteLine("He will need {0:0.00} dollars to survive.", Math.Abs(money));
            }
        }
    }
}

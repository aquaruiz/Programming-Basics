using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetCups = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var totalWorkHours = workDays * workers * 8;
            var totalCups = Math.Floor(totalWorkHours / 5.0);
            var targetPrice = targetCups * 4.20;
            var totalPrice = totalCups * 4.20;

            if (totalCups > targetCups)
            {
                Console.WriteLine("{0:f2} extra money", totalPrice - targetPrice);
            }
            else
            {
                Console.WriteLine("Losses: {0:f2}", targetPrice - totalPrice);
            }
        }
    }
}

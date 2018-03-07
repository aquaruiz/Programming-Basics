using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var windowsQnty = int.Parse(Console.ReadLine());
            var sqmPerBoxStyrofoam = double.Parse(Console.ReadLine());
            var priceBoxStyrofoam = double.Parse(Console.ReadLine());

            var totalArea = houseArea - windowsQnty * 2.4;
            var StyrofoamQnty = (1 + 0.1) * totalArea;
            var StyrofoamBoxes = Math.Ceiling(StyrofoamQnty / sqmPerBoxStyrofoam);
            var price = StyrofoamBoxes * priceBoxStyrofoam;

            if (budget >= price)
            {
                Console.WriteLine("Spent: {0:f2}", price);
                Console.WriteLine("Left: {0:f2}", budget - price);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", price - budget);
            }
        }
    }
}

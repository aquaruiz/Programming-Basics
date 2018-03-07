using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int sqmWineyard = int.Parse(Console.ReadLine());
            double grapePerSqm = double.Parse(Console.ReadLine());
            int litersWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            var grapeHarvest = sqmWineyard * grapePerSqm;
            var GrapeForWine = 0.4 * grapeHarvest;
            var wineHasvest = GrapeForWine / 2.5;

            if (wineHasvest >= litersWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineHasvest));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineHasvest - litersWine), Math.Ceiling((wineHasvest - litersWine) / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(litersWine - wineHasvest));
            }
        }
    }
}

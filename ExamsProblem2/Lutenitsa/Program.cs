using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lutenitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var kgTomatoes = double.Parse(Console.ReadLine());
            var AvailableKassettes = int.Parse(Console.ReadLine());
            var glassesPerKassette = int.Parse(Console.ReadLine());

            var totalLutenitza = kgTomatoes / 5.0;
            var neededGlasses = totalLutenitza / 0.535;
            var neededKassetees = neededGlasses / glassesPerKassette;

            Console.WriteLine("Total lutenica: {0} kilograms.", Math.Floor(totalLutenitza));
            if (AvailableKassettes < neededKassetees)
            {
                Console.WriteLine("{0} boxes left.", Math.Floor(neededKassetees - AvailableKassettes));
                Console.WriteLine("{0} jars left.", Math.Floor(neededGlasses - AvailableKassettes * glassesPerKassette));
            }
            else if (neededKassetees <= AvailableKassettes)
            {
                Console.WriteLine("{0} more boxes needed.", Math.Floor(AvailableKassettes - neededKassetees));
                Console.WriteLine("{0} more jars needed.", Math.Floor(AvailableKassettes * glassesPerKassette - neededGlasses));
            }
        }
    }
}

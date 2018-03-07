using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeAndRakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyardArea = double.Parse(Console.ReadLine());
            var kgPerSqm = double.Parse(Console.ReadLine());
            var waiste = double.Parse(Console.ReadLine());
            var grapeQnty = vineyardArea * kgPerSqm - waiste;
            var grapeForRakia = 0.45 * grapeQnty;
            var sells = 0.55 * grapeQnty;
            var rakiaVolume = grapeForRakia / 7.5;
            var rakiaTotalPrice = rakiaVolume * 9.8;
            var grapeTotalPrice = sells * 1.5;

            Console.WriteLine("{0:f2}", rakiaTotalPrice);
            Console.WriteLine("{0:f2}", grapeTotalPrice);
        }
    }
}

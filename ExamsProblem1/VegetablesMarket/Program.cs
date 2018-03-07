using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetablesMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegsPriceLvPerKg = float.Parse(Console.ReadLine());
            var fruitPriceLvPerKg = float.Parse(Console.ReadLine());
            var vegsKgs = int.Parse(Console.ReadLine());
            var fruitsKgs = int.Parse(Console.ReadLine());

            var totalPriceVegsLv = vegsPriceLvPerKg * vegsKgs;
            var totalPriceFruitsLv = fruitPriceLvPerKg * fruitsKgs;
            var totalPriceLv = totalPriceVegsLv + totalPriceFruitsLv;
            var totalPriceEuro = totalPriceLv / 1.94;

            Console.WriteLine(totalPriceEuro);

        }
    }
}

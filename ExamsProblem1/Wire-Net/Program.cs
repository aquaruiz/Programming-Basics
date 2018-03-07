using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wire_Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var pricePerSqrtMeter = double.Parse(Console.ReadLine());
            var weight = double.Parse(Console.ReadLine());

            var perimeter = length * 2 + width * 2;
            var totalPrice = perimeter * pricePerSqrtMeter;
            var totalWeight = perimeter * height * weight;

            Console.WriteLine(perimeter);
            Console.WriteLine("{0:f2}", totalPrice);
            Console.WriteLine("{0:f3}", totalWeight);
        }
    }
}

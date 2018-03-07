using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());
            var houseArea = 2 * A * A / 2 + 2 * (A / 2 * A / 2 + ((A / 2) * (B - (A / 2)) / 2)) - ((A / 5) * (A / 5));
            var roofArea = 2 * (A * A / 2);
            var greenPaint = Math.Round((houseArea / 3), 2);
            var redPaint = Math.Round((roofArea / 5), 2);
            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var houseArea = 2 * x * x + 2 * x * y - 1.2 * 2 - 2 * 1.5 * 1.5;
            var roofArea = 2 * x * y + 2 * (x * h / 2);
            var greenPaint = Math.Round((houseArea / 3.4), 2);
            var redPaint = Math.Round((roofArea / 4.3), 2);
            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}

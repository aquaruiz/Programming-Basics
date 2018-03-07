using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var price = 0.0;
            var van = 0.0;
            var truck = 0.0;
            var train = 0.0;
            var totalFreight = 0.0;

            for (int i = 0; i < n; i++)
            {
                var freight = int.Parse(Console.ReadLine());
                totalFreight += freight;
                if (freight <= 3)
                {
                    price += 200 * freight;
                    van += freight;
                }
                else if (freight <= 11)
                {
                    price += 175 * freight;
                    truck += freight;
                }
                else if (freight >= 12)
                {
                    price += 120 * freight;
                    train += freight;
                }
            }

            var average = price / totalFreight;

            Console.WriteLine("{0:f2}", average);
            Console.WriteLine("{0:f2}%", van / totalFreight * 100);
            Console.WriteLine("{0:f2}%", truck / totalFreight * 100);
            Console.WriteLine("{0:f2}%", train / totalFreight * 100);
        }
    }
}

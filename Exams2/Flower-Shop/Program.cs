using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var flower1 = int.Parse(Console.ReadLine());
            var flower2 = int.Parse(Console.ReadLine());
            var flower3 = int.Parse(Console.ReadLine());
            var cactus = int.Parse(Console.ReadLine());
            var presentPrice = double.Parse(Console.ReadLine());

            var flowerPrice = flower1 * 3.25 + flower2 * 4 + flower3 * 3.5 + cactus * 8;
            var totalPrice = flowerPrice * (1 - 0.05);

            if (presentPrice <= totalPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(totalPrice - presentPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(presentPrice - totalPrice));
            }
        }
    }
}

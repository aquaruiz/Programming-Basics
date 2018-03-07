using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            var picQnty = int.Parse(Console.ReadLine());
            var picType = Console.ReadLine();
            var orderingType = Console.ReadLine().ToLower();

            var picPrice = 0.0;

            if (picType == "9X13")
            {
                picPrice = 0.16;
                if (picQnty > 50)
                   picPrice -= 0.05 * picPrice;
            }
            else if (picType == "10X15")
            {
                picPrice = 0.16;
                if (picQnty > 80)
                    picPrice -= 0.03 * picPrice;
            }
            else if (picType == "13X18")
            {
                picPrice = 0.38;
                if (picQnty >= 50 && picQnty <= 100)
                    picPrice -= 0.03 * picPrice;
                else if (picQnty > 100)
                    picPrice -= 0.05 * picPrice;
            }
            else if (picType == "20X30")
            {
                picPrice = 2.90;
                if (picQnty > 10 && picQnty < 50)
                    picPrice -= 0.07 * picPrice;
                else if (picQnty >= 50)
                    picPrice -= 0.09 * picPrice;
            }

            if (orderingType == "online")
            {
                picPrice -= 0.02 * picPrice;
            }

            var bill = picPrice * picQnty;

            Console.WriteLine("{0:f2}BGN", bill);
        }
    }
}

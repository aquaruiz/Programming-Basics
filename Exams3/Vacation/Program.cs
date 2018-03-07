using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var overnights = int.Parse(Console.ReadLine());
            var transportation = Console.ReadLine().ToLower();

            var price = 0.0;

            if (transportation == "train")
                price = (adults * 24.99 + students * 14.99) * 2;
            else if (transportation == "bus")
                price = (adults * 32.50 + students * 28.50) * 2;
            else if (transportation == "boat")
                price = (adults * 42.99 + students * 39.99) * 2;
            else if (transportation == "airplane")
                price = (adults * 70 + students * 50) * 2;

            if (transportation == "train" && (adults + students) >= 50)
                price -= 0.50 * price;

            price += overnights * 82.99;
            price += 0.1 * price;

            Console.WriteLine($"{price:f2}");
        }
    }
}

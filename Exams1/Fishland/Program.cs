using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumriqPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var palamudQnty = double.Parse(Console.ReadLine());
            var safridQnty = double.Parse(Console.ReadLine());
            var midiQnty = double.Parse(Console.ReadLine());
            var palamudPrice = skumriqPrice * (1 + 0.60);
            var safridPrice = cacaPrice * (1 + 0.80);
            var midiPrice = 7.50;
            var totalPrice = Math.Round((palamudQnty * palamudPrice + safridQnty * safridPrice + midiQnty * midiPrice), 2);
            Console.WriteLine("{0:f2}", totalPrice);

        }
    }
}

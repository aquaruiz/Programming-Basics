using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoinQnty = int.Parse(Console.ReadLine());
            var yuanQnty = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());

            var bitcoinToLv = bitcoinQnty * 1168;
            var bitcoinToEuro = bitcoinToLv / 1.95;

            var yuanToUsd = yuanQnty * 0.15;
            var yuanToLv = yuanToUsd * 1.76;
            var yuanToEuro = yuanToLv / 1.95;

            var totalEuro = bitcoinToEuro + yuanToEuro;
            var endEuro = totalEuro * (1 - comission / 100);

            Console.WriteLine("{0:f2}", endEuro);
        }
    }
}

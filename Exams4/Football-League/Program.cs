using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacity = int.Parse(Console.ReadLine());
            var fens = double.Parse(Console.ReadLine());
            var aSectorFens = 0.0;
            var bSectorFens = 0.0;
            var vSectorFens = 0.0;
            var gSectorFens = 0.0;

            for (int i = 0; i < fens; i++)
            {
                var sector = Console.ReadLine().ToLower();
                if (sector == "a")
                    aSectorFens += 1;
                else if (sector == "b")
                    bSectorFens += 1;
                else if (sector == "v")
                    vSectorFens += 1;
                else if (sector == "g")
                    gSectorFens += 1;
            }

            Console.WriteLine("{0:f2}%", aSectorFens / fens * 100);
            Console.WriteLine("{0:f2}%", bSectorFens / fens * 100);
            Console.WriteLine("{0:f2}%", vSectorFens / fens * 100);
            Console.WriteLine("{0:f2}%", gSectorFens / fens * 100);
            Console.WriteLine("{0:f2}%", fens / capacity * 100);
        }
    }
}

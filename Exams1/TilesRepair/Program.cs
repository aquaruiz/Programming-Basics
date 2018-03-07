using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilesRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            var longSideN = int.Parse(Console.ReadLine());
            var tileWidthW = double.Parse(Console.ReadLine());
            var tileLengthL = double.Parse(Console.ReadLine());
            var benchwidthM = int.Parse(Console.ReadLine());
            var benchLengthO = int.Parse(Console.ReadLine());

            var sideArea = longSideN * longSideN;
            var benchArea = benchwidthM * benchLengthO;
            var tileArea = tileWidthW * tileLengthL;
            var tiledQnty = (sideArea - benchArea) / tileArea;
            var tiledTime = tiledQnty * 0.2;

            Console.WriteLine("{0:f2}", tiledQnty);
            Console.WriteLine("{0:f2}", tiledTime);
        }
    }
}

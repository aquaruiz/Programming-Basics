using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiles_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalMoney = double.Parse(Console.ReadLine());
            var widthFloor = double.Parse(Console.ReadLine());
            var lengthFloor = double.Parse(Console.ReadLine());
            var sideTile = double.Parse(Console.ReadLine());
            var heightTile = double.Parse(Console.ReadLine());
            var priceTile = double.Parse(Console.ReadLine());
            var masterPrice = double.Parse(Console.ReadLine());

            var floorArea = widthFloor * lengthFloor;
            var tileArea = sideTile * heightTile / 2.0;
            var totalTiles = Math.Ceiling(floorArea / tileArea) + 5;
            var totalPrice = totalTiles * priceTile + masterPrice;

            if (totalMoney >= totalPrice)
            {
                Console.WriteLine("{0:f2} lv left.", totalMoney - totalPrice);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", totalPrice - totalMoney);
            }
        }
    }
}

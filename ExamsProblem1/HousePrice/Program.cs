using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoomArea = double.Parse(Console.ReadLine());
            var kitchenArea = double.Parse(Console.ReadLine());
            var sqmPrice = double.Parse(Console.ReadLine());
            var bathroomArea = smallestRoomArea / 2.0;
            var secondroomArea = smallestRoomArea * (1 + 0.1);
            var thirdroomArea = secondroomArea * (1 + 0.1);
            var totalArea = (smallestRoomArea + kitchenArea + bathroomArea + secondroomArea + thirdroomArea) * (1 + 0.05);
            var flatPrice = Math.Round((totalArea * sqmPrice), 2);
            Console.WriteLine("{0:f2}", flatPrice);
        }
    }
}

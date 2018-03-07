using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Swimming_Champ
{
    class Program
    {
        static void Main(string[] args)
        {
            var worldRecordInSec = double.Parse(Console.ReadLine());
            var distanceInMeter = double.Parse(Console.ReadLine());
            var secPerMeter = double.Parse(Console.ReadLine());

            var totalTimeInSec = distanceInMeter * secPerMeter + Math.Floor((distanceInMeter / 15)) * 12.5;

            if (totalTimeInSec < worldRecordInSec)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", totalTimeInSec);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", totalTimeInSec - worldRecordInSec);
            }
        }
    }
}

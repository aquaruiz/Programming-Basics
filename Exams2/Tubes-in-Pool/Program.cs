using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_in_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            double volumeV = double.Parse(Console.ReadLine());
            int literPerHourP1 = int.Parse(Console.ReadLine());
            int literPerHourP2 = int.Parse(Console.ReadLine());
            double hoursH = double.Parse(Console.ReadLine());

            double LiterInPool = literPerHourP1 * hoursH + literPerHourP2 * hoursH;
            double percentPool = Math.Floor((LiterInPool / volumeV) * 100);

            if (percentPool <= 100)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentPool, Math.Floor((literPerHourP1 * hoursH) / LiterInPool * 100), Math.Floor((literPerHourP2 * hoursH) / LiterInPool * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", hoursH, LiterInPool - volumeV);
            }
        }
    }
}

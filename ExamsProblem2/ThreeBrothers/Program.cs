using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double cleanAlone1 = double.Parse(Console.ReadLine());
            double cleanAlone2 = double.Parse(Console.ReadLine());
            double cleanAlone3 = double.Parse(Console.ReadLine());
            double goneTime = double.Parse(Console.ReadLine());

            var cleanTogether = 1 / (1 / cleanAlone1 + 1 / cleanAlone2 + 1 / cleanAlone3);
            var totalTime = cleanTogether * (1 + 0.15);

            Console.WriteLine("Cleaning time: {0:f2}", totalTime);
            if (totalTime <= goneTime)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(goneTime - totalTime));
            }
            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(totalTime - goneTime));
            }
        }
    }
}

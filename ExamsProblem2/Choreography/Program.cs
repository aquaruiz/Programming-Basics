using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            var stepQnty = double.Parse(Console.ReadLine());
            var dancersQnty = double.Parse(Console.ReadLine());
            var studingDays = double.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling(((stepQnty / studingDays) / stepQnty) * 100);

            if (stepsPerDay <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%", stepsPerDay / dancersQnty);
            }
            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", stepsPerDay / dancersQnty);
            }
        }
    }
}

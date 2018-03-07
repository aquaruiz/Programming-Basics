using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetHours = int.Parse(Console.ReadLine());
            var workersQnty = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var totalHours = workersQnty * workDays * 8;

            if (totalHours >= targetHours)
            {
                Console.WriteLine("{0} hours left", totalHours - targetHours);
            }
            else
            {
                Console.WriteLine("{0} overtime", targetHours - totalHours);
                Console.WriteLine("Penalties: {0}", (targetHours - totalHours) * workDays);
            }
        }
    }
}

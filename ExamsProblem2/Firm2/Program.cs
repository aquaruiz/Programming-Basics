using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var hoursAvaible = days * (1 - 0.1) * 8;
            var extraHours = workers * 2 * days;
            var totalHours = hoursAvaible + extraHours;

            if (totalHours >= hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(totalHours - hoursNeeded));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(hoursNeeded - totalHours));
            }
        }
    }
}

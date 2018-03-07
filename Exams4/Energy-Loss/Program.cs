using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var dancers = int.Parse(Console.ReadLine());
            var totalEnergy = 100 * dancers * days;
            var usedEnergy = 0.0;

            for (int i = 1; i <= days; i++)
            {
                var hours = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && hours % 2 == 0)
                    usedEnergy += dancers * 68;
                else if (i % 2 != 0 && hours % 2 == 0)
                    usedEnergy += dancers * 49;
                else if (i % 2 == 0 && hours % 2 != 0)
                    usedEnergy += dancers * 65;
                else if (i % 2 != 0 && hours % 2 != 0)
                    usedEnergy += dancers * 30;
            }

            Console.WriteLine((totalEnergy - usedEnergy) / dancers / days);
        }
    }
}

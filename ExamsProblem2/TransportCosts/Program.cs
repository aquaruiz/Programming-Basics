using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCosts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double costs = 0.0;
            if (num < 20)
            {
                if (day == "day")
                {
                    costs = 0.70 + 0.79 * num;
                }
                else if (day == "night")
                    costs = 0.70 + 0.90 * num;
            }
            else if (num >= 20 && num <100)
            {
                costs = 0.09 * num;
            }
            else if (num >= 100)
            {
                costs = num * 0.06;
            }
            Console.WriteLine("{0:f2}", costs);
        }
    }
}

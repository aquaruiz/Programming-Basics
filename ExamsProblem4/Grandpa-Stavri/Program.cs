using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalLiters = 0.0;
            var totalDegrees = 0.0;

            for (int i = 0; i < n; i++)
            {
                var liters = double.Parse(Console.ReadLine());
                var degrees = double.Parse(Console.ReadLine());

                totalLiters += liters;
                totalDegrees += degrees * liters;
            }

            totalDegrees = totalDegrees / totalLiters;

            Console.WriteLine("Liter: {0:f2}", totalLiters);
            Console.WriteLine("Degrees: {0:f2}", totalDegrees);
            if (totalDegrees < 38)
                Console.WriteLine("Not good, you should baking!");
            else if (totalDegrees >= 38 && totalDegrees < 42)
                Console.WriteLine("Super!");
            else if (totalDegrees >= 42)
                Console.WriteLine("Dilution with distilled water!");
        }
    }
}

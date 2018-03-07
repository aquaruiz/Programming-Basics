using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var devisionBy2 = 0.0;
            var devisionBy3 = 0.0;
            var devisionBy4 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                    devisionBy2++;
                if (num % 3 == 0)
                    devisionBy3++;
                if (num % 4 == 0)
                    devisionBy4++;
            }

            Console.WriteLine("{0:0.00}%", devisionBy2 / n * 100);
            Console.WriteLine("{0:0.00}%", devisionBy3 / n * 100);
            Console.WriteLine("{0:0.00}%", devisionBy4 / n * 100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = n;
            var dies = 3 * n;

            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine(new string('.', dots) + new string('#', dies) + new string('.', dots));
                dots++;
                dies -= 2;
            }

            for (int row = 0; row < n / 2 + 1; row++)
            {
                Console.WriteLine(new string('.', dots) + "#" + new string('.', dies - 2) + "#" + new string('.', dots));
                dies -= 2;
                dots++;
            }

            Console.WriteLine(new string('.', dots - 1) + new string('#', dies + 2) + new string('.', dots - 1));

            for (int row = 0; row < n + 2; row++)
            {
                if (row == (n + 2) / 2 - 1)
                {
                    Console.WriteLine(new string('.', ( 5 * n - 10) / 2) + "D^A^N^C^E^" + new string('.', (5 * n - 10) / 2));
                }
                else
                Console.WriteLine(new string('.', dots - 3) + new string('#', dies + 6) + new string('.', dots - 3));
            }
        }
    }
}

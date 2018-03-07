using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = (12 * n - 5 - 1) / 2;
            var dies = 1;

            for (int row = 0; row < 2 * n - 1; row++)
            {
                Console.WriteLine(new string('.', dots) + new string('#', dies) + new string('.', dots));
                dots -= 3;
                dies += 6;
            }

            Console.WriteLine(new string('#', 12 * n - 5));

            dots += 3;
            dies -= 6;
            for (int row = 0; row < n - 2; row++)
            {
                Console.WriteLine("|" + new string('.', dots - 1) + new string('#', dies) + new string('.', dots));
                dots += 3;
                dies -= 6;
            }

            for (int row = 0; row < n; row++)
            {
                if (row == n - 1)
                {
                    Console.WriteLine("@" + new string('.', dots - 1) + new string('#', dies) + new string('.', dots));
                }
                else
                Console.WriteLine("|" + new string('.', dots - 1) + new string('#', dies) + new string('.', dots));
            }
        }
    }
}

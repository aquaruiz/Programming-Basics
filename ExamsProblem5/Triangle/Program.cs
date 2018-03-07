using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int dots = 1;
            int dies = (4 * n - 1) / 2;
            int spaces = 1;

            Console.WriteLine(new string('#', 4 * n + 1));
            for (int row = 1; row < n + 1; row++)
            {
                if (n % 2 == 0 & row == (n + 2) / 2)
                {
                    Console.WriteLine(new string('.', dots) + new string('#', dies) + new string(' ', (spaces - 3) / 2) + "(@)" + new string(' ', (spaces - 3) / 2) + new string('#', dies) + new string('.', dots));
                }
                else if ((n + 1) % 2 == 0 & row == (n + 1) / 2)
                {
                    Console.WriteLine(new string('.', dots) + new string('#', dies) + new string(' ', (spaces - 3) / 2) + "(@)" + new string(' ', (spaces - 3) / 2) + new string('#', dies) + new string('.', dots));
                }
                else
                Console.WriteLine(new string('.', dots) + new string('#', dies) + new string(' ', spaces) + new string('#', dies) + new string('.', dots));
                dots++;
                dies -= 2;
                spaces += 2;
            }

            dies = 2 * n - 1;
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('.', dots) + new string('#', dies) + new string('.', dots));
                dots++;
                dies -= 2;
            }
        }
    }
}

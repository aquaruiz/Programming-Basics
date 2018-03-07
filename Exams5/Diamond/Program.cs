using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = n;
            var middleDots = 3 * n - 2;

            for (int row = 0; row <= n; row++)
            {
                if (row == 0 || row == n)
                {
                    Console.WriteLine(new string('.', dots) + "*" + new string('*', middleDots) + "*" + new string('.', dots));
                }
                else
                Console.WriteLine(new string('.',dots) + "*" + new string('.', middleDots) + "*" + new string('.', dots));
                dots--;
                middleDots += 2;
            }

            dots += 2;
            middleDots -= 4;
            for (int row = 0; row <= 2 * n; row++)
            {
                if (row == 2 * n)
                {
                    Console.WriteLine(new string('.', dots) + "*" + new string('*', n - 4) + "*" + new string('.', dots));
                }
                else
                Console.WriteLine(new string('.', dots) + "*" + new string('.', middleDots) + "*" + new string('.', dots));
                dots++;
                middleDots -= 2;
            }
        }
    }
}

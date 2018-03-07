using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = n;

            for (int row = 0; row < n; row++)
            {
                if (row == n - 1)
                {
                    Console.WriteLine(new string('.', row) + new string('*', 5) + new string('.', row));
                }
                else
                Console.WriteLine(new string('.', row) + "*" + new string('.', dots) + "*" + new string('.', dots) + "*" + new string('.', row));
                dots--;
            }
            Console.WriteLine(new string('*', 2 * n + 3));

            dots++;
            for (int row = n - 1; row >= 0; row--)
            {
                if (row == n - 1)
                {
                    Console.WriteLine(new string('.', row) + new string('*', 5) + new string('.', row));
                }
                else
                Console.WriteLine(new string('.', row) + "*" + new string('.', dots) + "*" + new string('.', dots) + "*" + new string('.', row));
                dots++;
            }

        }
    }
}

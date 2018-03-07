using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = (4 * n + 1 - 3) / 2;
            Console.WriteLine(new string('.', dots) + "/|\\" + new string('.', dots));
            Console.WriteLine(new string('.', dots) + "\\|/" + new string('.', dots));

            var underscore = 0;

            for (int row = 0; row < 2 * n ; row++)
            {
                Console.WriteLine(new string('.', dots) + "*" + new string('-', underscore) + "*" + new string('-', underscore) +"*" + new string('.', dots));
                dots--;
                underscore++;
            }

            var rows = new string('*', 4 * n + 1);

            Console.WriteLine(rows);
            for (int row = 0; row < (4 * n) / 2; row++)
            {
                Console.Write("*");
                Console.Write(".");
            }

            Console.WriteLine("*");
            Console.WriteLine(rows);
        }
    }
}

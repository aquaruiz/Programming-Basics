using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = 1;
            var kljomba = 2 * n + 1 - 6;
            var spaces = 0;

            Console.WriteLine(new string('*', 2 * n + 1));
            Console.WriteLine(new string('.', dots) + "*" + new string(' ', kljomba + 2) + "*" + new string('.', dots));
            dots++;

            for (int row = 0; row < n - 2; row++)
            {
                Console.WriteLine(new string('.', dots) + "*" + new string('@', kljomba) + "*" + new string('.', dots));
                dots++;
                kljomba -= 2;
            }

            Console.WriteLine(new string('.', dots) + "*" + new string('.', dots));
            dots--;

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string('.', dots) + "*" + new string(' ', spaces) + "@" + new string(' ', spaces) + "*" + new string('.', dots));
                dots--;
                spaces++;
            }

            Console.WriteLine(new string('.', dots) + "*" + new string('@', n * 2 + 1 - 4) + "*" + new string('.', dots));
            Console.WriteLine(new string('*', 2 * n + 1));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = (3 * n - 2) / 2;
            var space = 0;

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('.', dots) + "/" + new string(' ', space) + "\\" + new string('.', dots));
                dots--;
                space += 2;
            }

            dots++;
            Console.WriteLine(new string('.', dots) + new string('*', space) + new string('.', dots));

            for (int row = 0; row < 2 * n; row++)
            {
                Console.WriteLine(new string('.', dots) + "|" +  new string('\\', space - 2) + "|" + new string('.', dots));
            }

            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine(new string('.', dots) + "/" + new string('*', space - 2) + "\\" + new string('.', dots));
                dots--;
                space += 2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("@" + new string(' ', (2 * n - 1 - 3 ) / 2) + "@" + new string(' ', (2 * n - 1 - 3) / 2) + "@");
            Console.WriteLine("**" + new string(' ', (2 * n - 1 - 3) / 2 - 1) + "*" + new string(' ', (2 * n - 1 - 3) / 2 - 1) + "**");

            var spaces = (2 * n - 1 - 3) / 2 - 1 - 2;
            var dots = 1;
            var middleDots = 1;

            for (int row = 0; row < n / 2 - 2; row++)
            {
                Console.WriteLine("*" + new string('.', dots) + "*" + new string(' ', spaces) + "*" + new string('.', middleDots) + "*" + new string(' ', spaces) + "*" + new string('.', dots) + "*");
                dots++;
                spaces -= 2;
                middleDots += 2;
            }

            Console.WriteLine("*" + new string('.', dots) + "*" + new string('.', middleDots) + "*" + new string('.', dots) + "*");
            dots++;

            Console.WriteLine("*" + new string('.', dots) + new string('*', middleDots / 2) + "." + new string('*', middleDots / 2)  + new string('.', dots) + "*");

            Console.WriteLine(new string('*', 2 * n - 1));
            Console.WriteLine(new string('*', 2 * n - 1));
        }
    }
}

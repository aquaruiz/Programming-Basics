using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var middleDashes = 0;
            var rightDashes = 2 * n - 2;

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('-', 3 * n) + "*" + new string('-', middleDashes) + "*" + new string('-', rightDashes));
                middleDashes++;
                rightDashes--;
            }

            middleDashes--;
            rightDashes++;

            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine(new string('*', 3 * n + 1) + new string('-', middleDashes) + "*" + new string('-', rightDashes));
            }

            var leftDashes = 3 * n;
            for (int row = 0; row < n / 2 - 1; row++)
            {
                Console.WriteLine(new string('-', leftDashes) + "*" + new string('-', middleDashes) + "*" + new string('-', rightDashes));
                leftDashes--;
                middleDashes += 2;
                rightDashes--;
            }

            Console.WriteLine(new string('-', leftDashes) + "*" + new string('*', middleDashes) + "*" + new string('-', rightDashes));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dots = n + 1;
            var underscores = 2 * n + 1;

            Console.WriteLine(new string('.', dots) + new string('_', underscores) + new string('.', dots));

            for (int row = 0; row < n + 1; row++)
            {
                dots--;
                underscores += 2;
                if (row == n)
                {
                    Console.WriteLine(new string('.', dots) + "//" + new string('_', (underscores - 4 - 5) / 2) + "STOP!" + new string('_', (underscores - 4 - 5) / 2) + "\\\\" + new string('.', dots));
                }
                else
                Console.WriteLine(new string('.', dots) + "//" + new string('_', underscores - 4) + "\\\\" + new string('.', dots));
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('.', dots) + "\\\\" + new string('_', underscores - 4) + "//" + new string('.', dots));
                dots++;
                underscores -= 2;
            }
        }
    }
}

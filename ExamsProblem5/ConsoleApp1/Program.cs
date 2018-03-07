using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}x{0}", new string('.', 3 * n / 2));
            Console.WriteLine("{0}/x\\{0}", new string('.', 3 * n / 2 - 1));
            Console.WriteLine("{0}x|x{0}", new string('.', 3 * n / 2 - 1));

            var x = n;
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', ((3 * n) - (x * 2 + 1)) / 2), new string('x', x));
                x++;
            }

            for (int i = n / 2; i > 0; i--)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', ((3 * n) - (x * 2 + 1)) / 2), new string('x', x));
                x--;
            }

            Console.WriteLine("{0}/x\\{0}", new string('.', 3 * n / 2 - 1));
            Console.WriteLine("{0}\\x/{0}", new string('.', 3 * n / 2 - 1));
        }
    }
}

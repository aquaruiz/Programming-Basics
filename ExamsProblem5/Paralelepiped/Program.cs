using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftDots = 0;
            var rightDots = 3 * n + 1 - n;
            Console.WriteLine("+" + new string('~', n - 2) + "+" + new string('.', rightDots));

            var line = "\\" + new string('~', n - 2) + "\\";

            rightDots--;
            for (int row = 0; row < n * 2 + 1; row++)
            {
                Console.WriteLine("|" + new string('.', leftDots) + line + new string('.', rightDots));
                leftDots++;
                rightDots--;
            }

            leftDots--;
            rightDots++;
            line = "|" + new string('~', n - 2) + "|";

            for (int row = 0; row < n * 2 + 1; row++)
            {
                Console.WriteLine(new string('.', rightDots) + "\\" + new string('.', leftDots) + line);
                rightDots++;
                leftDots--;
            }

            Console.WriteLine(new string('.', rightDots) + "+" + new string('~', n - 2) + "+");
        }
    }
}

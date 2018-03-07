using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("|" + new string('-', 2 * n) + "|");
            Console.WriteLine("|" + new string('*', 2 * n) + "|");

            int dashes = n;
            int chavka = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                Console.WriteLine("|" + new string('-', dashes) + new string('~', chavka) + new string('~', chavka) + new string('-', dashes) + "|");
                dashes--;
                chavka++;
            }

            dashes++;
            chavka--;
            dashes++;
            chavka--;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|" + new string('-', dashes) + new string('~', chavka) + new string('~', chavka) + new string('-', dashes) + "|");
                dashes++;
                chavka--;
            }

            dashes = 0;
            int dots = 2 * n + 1;
            int dolnaChast = n + 3;
            int merry = dolnaChast / 2 - 2;
            int xMAS = merry + 2;

            for (int i = 0; i < dolnaChast; i++)
            {
                if (i == dolnaChast - 1)
                {
                    Console.WriteLine(new string('-', dashes) + "\\" + new string('_', dots) + ")");
                }
                else if (i == merry && n % 2 != 0)
                {
                    Console.WriteLine(new string('-', dashes) + "\\" + new string('.', (dots - 5) / 2) + "MERRY" + new string('.', (dots - 5) / 2) + "\\");
                    dashes++;
                }
                else if (i == merry + 1 && n % 2 == 0)
                {
                    Console.WriteLine(new string('-', dashes) + "\\" + new string('.', (dots - 5) / 2) + "MERRY" + new string('.', (dots - 5) / 2) + "\\");
                    dashes++;
                }
                else if (i == xMAS && n % 2 != 0)
                {
                    Console.WriteLine(new string('-', dashes) + "\\" + new string('.', (dots - 5) / 2) + "X-MAS" + new string('.', (dots - 5) / 2) + "\\");
                    dashes++;
                }
                else if (i == xMAS + 1 && n % 2 == 0)
                {
                    Console.WriteLine(new string('-', dashes) + "\\" + new string('.', (dots - 5) / 2) + "X-MAS" + new string('.', (dots - 5) / 2) + "\\");
                    dashes++;
                }
                else
                {
                    Console.WriteLine(new string('-', dashes) + "\\" + new string('.', dots) + "\\");
                    dashes++;
                }
            }
        }
    }
}

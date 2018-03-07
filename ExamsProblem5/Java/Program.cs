using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                Console.Write(new string(' ', n));
                Console.WriteLine("~ ~ ~");
            }

            string ravnota = new string('=', 3 * n + 5);
            string holder = new string(' ', n - 1) + '|';
            Console.WriteLine(ravnota);

            string javaRows = new string('~', 2 * n + 4);
            for (int row = 0; row < n - 2; row++)
            {
                if (row == (n - 2) / 2)
                {
                    Console.WriteLine("|" + new string('~', n) + "JAVA" + new string('~', n) + "|" + holder);
                }
                else
                    Console.WriteLine("|{0}|{1}", javaRows, holder);
            }

            Console.WriteLine(ravnota);

            var kljomba = 2 * n + 4;
            var space = 0;
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string (' ', space) + "\\" + new string('@', kljomba) + "/");
                kljomba -= 2;
                space++;
            }

            ravnota = new string('=', 2 * n + 6);
            Console.WriteLine(ravnota);

        }
    }
}

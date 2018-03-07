using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 1;
            var dash = 2 * n + 3 - 4;

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('*', stars) + "\\" + new string('-', dash) + "/" + new string('*', stars));
                stars++;
                dash -= 2;
            }

            var middleStar = n / 2;
            var middleStar2 = n;
            for (int row = 0; row < n / 3; row++)
            {
                Console.WriteLine("|" + new string('*', middleStar) + "\\" + new string('*', middleStar2 ) + "/" + new string('*', middleStar) + "|");
                middleStar++;
                middleStar2 -= 2;
            }

            stars = 1;
            dash = 2 * n + 3 - 4;
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(new string('-', stars) + "\\" + new string('*', dash) + "/" + new string('-', stars));
                stars++;
                dash -= 2;
            }
        }
    }
}

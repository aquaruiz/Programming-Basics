using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var i = 0;
            var password = "";

            for (int a = 1; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            if (a < b && c > d && m == a * b + c * d && (c != 0 && d != 0))
                            {
                                Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                                i++;
                                if (i == 4)
                                {
                                    password = $"{a}{b}{c}{d}";
                                }
                            }
                        }
                    }
                }
            }

            if (i >= 4)
            {
                Console.WriteLine();
                Console.WriteLine("Password: {0}", password);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
        }
    }
}

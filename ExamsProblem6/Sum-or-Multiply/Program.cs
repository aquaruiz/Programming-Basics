using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_or_Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int check = 0;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a + b + c == n && (a < b && b < c))
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {n}");
                            check = 1;
                        }
                        if (a * b * c == n && (a > b && b > c))
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {n}");
                            check = 1;
                        }
                    }
                }
            }
            if (check == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}

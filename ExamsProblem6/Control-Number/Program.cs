using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int control = int.Parse(Console.ReadLine());

            int sum = 0;
            int moves = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum += i * 2 + j * 3;
                    moves++;
                    if (sum >= control)
                    {
                        break;
                    }
                }
                if (sum >= control)
                {
                    break;
                }
            }

            if (sum >= control)
            {
                Console.WriteLine($"{moves} moves");
                Console.WriteLine($"Score: {sum} >= {control}");
            }
            else
            {
                Console.WriteLine($"{moves} moves");
            }
        }
    }
}

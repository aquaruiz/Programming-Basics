using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = int.Parse(Console.ReadLine());
            int count2 = int.Parse(Console.ReadLine());
            int count5 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= count1; i++)
            {
                for (int j = 0; j <= count2; j++)
                {
                    for (int k = 0; k <= count5; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", i, j, k, sum);
                        }
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int special = int.Parse(Console.ReadLine());
            int control = int.Parse(Console.ReadLine());

            int mnl = 100 * m + 10 * n + l;

            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        mnl = 100 * i + 10 * j + k;
                        if (mnl % 3 == 0)
                        {
                            special += 5;
                        }
                        else if (mnl % 10 == 5)
                        {
                            special -= 2;
                        }
                        else if (mnl % 2 == 0)
                        {
                            special *= 2;
                        }

                        if (special >= control)
                        {
                            break;
                        }
                    }
                    if (special >= control)
                    {
                        break;
                    }
                }
                if (special >= control)
                {
                    break;
                }
            }
            if (special >= control)
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", special);
            }
            else
            {
                Console.WriteLine("No! {0} is the last reached special number.", special);
            }
        }
    }
}

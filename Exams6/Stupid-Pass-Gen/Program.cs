using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Pass_Gen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = 'a'; k <= 'a' + l - 1; k++)
                    {
                        for (char m = 'a'; m <= 'a' + l - 1; m++)
                        {
                            for (int o = 0; o <= n; o++)
                            {
                                if (o <= i || o <= j)
                                {
                                    continue;
                                }
                                Console.Write($"{i}{j}{k}{m}{o} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

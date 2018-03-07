using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            char skipped = char.Parse(Console.ReadLine());
            int combi = 0;

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i == skipped || j == skipped || k == skipped)
                        {
                            continue;
                        }
                        else
                        {
                            combi++;
                            Console.Write($"{i}{j}{k} ");
                            
                        }
                    }
                }
            }
            Console.WriteLine(combi);
        }
    }
}

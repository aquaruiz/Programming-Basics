using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int magical = int.Parse(Console.ReadLine());
            int combi = 0;

            int i;
            int j;
            string sum = "";

            for (i = start; i >= end; i--)
            {
                for (j = start; j >= end; j--)
                {
                    combi++;
                    if (i + j == magical)
                    {
                        Console.WriteLine($"Combination N:{combi} ({i} + {j} = {magical})");
                        sum = "+";
                        return;
                    }
                }
            }

            if (sum != "+")
            {
                Console.WriteLine($"{combi} combinations - neither equals {magical}");
            }
        }
    }
}

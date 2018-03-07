using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombi = int.Parse(Console.ReadLine());

            int combi = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combi++;
                    Console.Write($"<{i}-{j}>");
                    if (combi>= maxCombi)
                    {
                        return;
                    }
                }
            }
        }
    }
}

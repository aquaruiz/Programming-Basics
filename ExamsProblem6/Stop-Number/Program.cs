using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int stop = int.Parse(Console.ReadLine());

            for (int i = end; i >= start; i--)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    if (i == stop)
                    {
                        return;
                    }
                    Console.Write(i + " ");
                }
            }
        }
    }
}

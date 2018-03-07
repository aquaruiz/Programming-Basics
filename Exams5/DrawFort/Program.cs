using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
                        
            var underscores = n * 2 - 4 - 2 * (n / 2);
            if (n < 5)
                underscores = 0;
            if (underscores % 2 != 0)
            {
                underscores++;
            }

            var chafka = (n * 2 - 4 - underscores) / 2;
            var spaces = underscores + 2 * chafka + 2;
            Console.WriteLine("/" + new string('^', chafka) + "\\" + new string('_', underscores) + "/" + new string('^', chafka) + "\\");

            for (int row = 0; row < n - 2; row++)
            {
                if (row == n - 3)
                {
                    Console.WriteLine("|" + new string(' ', spaces / 2 - underscores / 2) + new string('_', underscores) + new string(' ', spaces / 2 - underscores / 2) + "|");
                }
                else
                    Console.WriteLine("|" + new string(' ', spaces) + "|");
            }
            
            Console.WriteLine("\\" + new string('_', chafka) + "/" + new string(' ', underscores) + "\\" + new string('_', chafka) + "/");
        }
    }
}

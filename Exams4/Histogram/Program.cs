using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var under200 = 0.0;
            var btw200and400 = 0.0;
            var btw400and600 = 0.0;
            var btw600and800 = 0.0;
            var over800 = 0.0;


            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200)
                    under200++;
                else if (num < 400)
                    btw200and400++;
                else if (num < 600)
                    btw400and600++;
                else if (num < 800)
                    btw600and800++;
                else
                    over800++;
            }

            Console.WriteLine("{0:0.00}%", under200 / n * 100);
            Console.WriteLine("{0:0.00}%", btw200and400 / n * 100);
            Console.WriteLine("{0:0.00}%", btw400and600 / n * 100);
            Console.WriteLine("{0:0.00}%", btw600and800 / n * 100);
            Console.WriteLine("{0:0.00}%", over800 / n * 100);
        }
    }
}

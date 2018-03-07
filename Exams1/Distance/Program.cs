using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSpeed = int.Parse(Console.ReadLine());
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            var secondSpeed = firstSpeed * (1 + 0.1);
            var thirdSpeed = secondSpeed * (1 - 0.05);
            var path1 = firstSpeed * time1 / 60.0;
            var path2 = secondSpeed * time2 / 60.0;
            var path3 = thirdSpeed * time3 / 60.0;
            var totalPath = Math.Round((path1 + path2 + path3), 2);
            Console.WriteLine("{0:f2}", totalPath);
        }
    }
}

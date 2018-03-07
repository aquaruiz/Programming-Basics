using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var totalScore = 0.0;
            var interval0009 = 0.0;
            var interval1019 = 0.0;
            var interval2029 = 0.0;
            var interval3039 = 0.0;
            var interval4050 = 0.0;
            var invalidNumbers = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num >= 0 && num <= 9)
                {
                    totalScore += 0.2 * num;
                    interval0009 += 1;
                }
                else if (num >= 10 && num <= 19)
                {
                    totalScore += 0.3 * num;
                    interval1019 += 1;
                }
                else if (num >= 20 && num <= 29)
                {
                    totalScore += 0.4 * num;
                    interval2029 += 1;
                }
                else if (num >= 30 && num <= 39)
                {
                    totalScore += 50;
                    interval3039 += 1;
                }
                else if (num >= 40 && num <= 50)
                {
                    totalScore += 100;
                    interval4050 += 1;
                }
                else
                {
                    totalScore = totalScore / 2;
                    invalidNumbers += 1;
                }
            }

            Console.WriteLine("{0:f2}", totalScore);
            Console.WriteLine("From 0 to 9: {0:f2}%", interval0009 / n * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", interval1019 / n * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", interval2029 / n * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", interval3039 / n * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", interval4050 / n * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalidNumbers / n * 100);
        }
    }
}

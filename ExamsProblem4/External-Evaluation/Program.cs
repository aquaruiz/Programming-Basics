using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var total = 0.0;
            var poorMarks = 0.0;
            var satisfactoryMarks = 0.0;
            var goodMarks = 0.0;
            var veryGoodMarks = 0.0;
            var excellentMarks = 0.0;

            for (int i = 0; i < n; i++)
            {
                double mark = double.Parse(Console.ReadLine());
                total += 1;

                if (mark < 22.5)
                    poorMarks += 1;
                else if (mark >= 22.5 && mark < 40.5)
                    satisfactoryMarks += 1;
                else if (mark >= 40.5 && mark < 58.5)
                    goodMarks += 1;
                else if (mark >= 58.5 && mark < 76.5)
                    veryGoodMarks += 1;
                else if (mark >= 76.5)
                    excellentMarks += 1;
            }

            Console.WriteLine("{0:f2}% poor marks", poorMarks / total * 100);
            Console.WriteLine("{0:f2}% satisfactory marks", satisfactoryMarks / total * 100);
            Console.WriteLine("{0:f2}% good marks", goodMarks / total * 100);
            Console.WriteLine("{0:f2}% very good marks", veryGoodMarks / total * 100);
            Console.WriteLine("{0:f2}% excellent marks", excellentMarks / total * 100);
        }
    }
}

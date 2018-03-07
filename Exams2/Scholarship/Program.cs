using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            var income = double.Parse(Console.ReadLine());
            var averageGrade = double.Parse(Console.ReadLine());
            var minSalary = double.Parse(Console.ReadLine());

            var socialScholarship = 0.0;
            var excellentScholarship = 0.0;

            if (averageGrade >= 4.50 && income <= minSalary)
            {
                socialScholarship = Math.Truncate((35 / 100.0) * minSalary);
            }

            if (averageGrade >= 5.50)
            {
                excellentScholarship = Math.Truncate(25.0 * averageGrade);
            }

            if (socialScholarship > excellentScholarship)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socialScholarship);
            }
            else if (socialScholarship < excellentScholarship)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", excellentScholarship);
            }
            else if (socialScholarship == 0 && excellentScholarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
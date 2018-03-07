using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var grade = 0.00;
            var topStudent = 0;
            var btw4And5 = 0;
            var btw3And4 = 0;
            var fail = 0;
            var totalGrade = 0.0;

            for (int i = 0; i < n; i++)
            {
                grade = double.Parse(Console.ReadLine());
                totalGrade += grade;
                if (grade >= 5)
                    topStudent++;
                else if (grade >= 4)
                    btw4And5++;
                else if (grade >= 3)
                    btw3And4++;
                else if (grade < 3)
                    fail++;
            }

            var average = totalGrade / n;

            Console.WriteLine("Top students: {0:0.00}%", topStudent / n * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:0.00}%", btw4And5 / n * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:0.00}%", btw3And4 / n * 100);
            Console.WriteLine("Fail: {0:0.00}%", fail / n * 100);
            Console.WriteLine("Average: {0:0.00}", average);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lectionsQnty = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var jelevSalary = 0.0;
            var royalSalary = 0.0;
            var roliSalary = 0.0;
            var trofonSalary = 0.0;
            var sinoSalary = 0.0;
            var otherSalary = 0.0;
            
            for (int i = 0; i < lectionsQnty; i++)
            {
                var lector = Console.ReadLine().ToLower();
                if (lector == "jelev")
                    jelevSalary += budget / lectionsQnty;
                else if (lector == "royal")
                    royalSalary += budget / lectionsQnty;
                else if (lector == "roli")
                    roliSalary += budget / lectionsQnty;
                else if (lector == "trofon")
                    trofonSalary += budget / lectionsQnty;
                else if (lector == "sino")
                    sinoSalary += budget / lectionsQnty;
                else
                    otherSalary += budget / lectionsQnty;
            }

            Console.WriteLine("Jelev salary: {0:f2} lv", jelevSalary);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royalSalary);
            Console.WriteLine("Roli salary: {0:f2} lv", roliSalary);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofonSalary);
            Console.WriteLine("Sino salary: {0:f2} lv", sinoSalary);
            Console.WriteLine("Others salary: {0:f2} lv", otherSalary);
        }
    }
}

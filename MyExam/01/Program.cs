using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double firstPresent = double.Parse(Console.ReadLine());
            double secondPresent = double.Parse(Console.ReadLine());
            double thirdPresent = double.Parse(Console.ReadLine());

            double totalPresents = firstPresent + secondPresent + thirdPresent;
            double BudgetLeft = budget - totalPresents;
            double taxes = BudgetLeft * 0.1;
            double leftAfterTaxes = BudgetLeft - taxes;

            Console.WriteLine("{0:f2}", leftAfterTaxes);
        }
    }
}

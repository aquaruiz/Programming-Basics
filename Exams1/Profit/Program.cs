using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var monthWorkingDays = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var usdLev = double.Parse(Console.ReadLine());
            var monthSalary = monthWorkingDays * moneyPerDay;
            var yearlySalary = monthSalary * 12 + 2.5 * monthSalary;
            var tax = yearlySalary * 0.25;
            var netoYearlySalary = yearlySalary - tax;
            var netoYearlySalaryUSD = netoYearlySalary * usdLev;
            var profitPerDay = Math.Round((netoYearlySalaryUSD / 365), 2);
            Console.WriteLine("{0:f2}", profitPerDay);
        }
    }
}

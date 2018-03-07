using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());
            var electricityBill = 0.0;
            var waterBill = 0.0;
            var internetBill = 0.0;
            var otherBill = 0.0;

            for (int i = 0; i < months; i++)
            {
                var electricity = double.Parse(Console.ReadLine());
                electricityBill += electricity;
                waterBill += 20;
                internetBill += 15;
            }
            otherBill += (electricityBill + waterBill + internetBill) * (1 + 0.2);

            Console.WriteLine("Electricity: {0:f2} lv", electricityBill);
            Console.WriteLine("Water: {0:f2} lv", waterBill);
            Console.WriteLine("Internet: {0:f2} lv", internetBill);
            Console.WriteLine("Other: {0:f2} lv", otherBill);
            Console.WriteLine("Average: {0:f2} lv", (electricityBill + waterBill + internetBill + otherBill) / months);
        }
    }
}

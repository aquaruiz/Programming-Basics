using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            var contractLength = Console.ReadLine().ToLower();
            var contractType = Console.ReadLine().ToLower();
            var addedInternet = Console.ReadLine().ToLower();
            var months = int.Parse(Console.ReadLine());

            var monthBill = 0.0;
            if (contractLength == "one")
            {
                if (contractType == "small")
                    monthBill = 9.98;
                else if (contractType == "middle")
                    monthBill = 18.99;
                else if (contractType == "large")
                    monthBill = 25.98;
                else if (contractType == "extralarge")
                    monthBill = 35.99;
            }
            else if (contractLength == "two")
            {
                if (contractType == "small")
                    monthBill = 8.58;
                else if (contractType == "middle")
                    monthBill = 17.09;
                else if (contractType == "large")
                    monthBill = 23.59;
                else if (contractType == "extralarge")
                    monthBill = 31.79;
            }

            if (addedInternet == "yes")
            {
                if (monthBill <= 10)
                    monthBill += 5.50;
                else if (monthBill <= 30)
                    monthBill += 4.35;
                else if (monthBill > 30)
                    monthBill += 3.85;
            }

            if (contractLength == "two")
            {
                monthBill -= 0.0375 * monthBill;
            }

            var price = monthBill * months;
            Console.WriteLine("{0:f2} lv.", price);
        }
    }
}

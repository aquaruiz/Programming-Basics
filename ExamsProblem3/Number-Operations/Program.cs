using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var oper = Console.ReadLine();

            var result = 0.0;

            switch (oper)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                case "%":
                    result = n1 % n2;
                    break;
            }

            var typ = "";

            if (result % 2 == 0)
                typ = "even";
            else
                typ = "odd";

            if (n2 == 0)
                Console.WriteLine("Cannot divide {0} by zero", n1);
            else
            {
                switch (oper)
                {
                    case "+":
                    case "-":
                    case "*":
                        Console.WriteLine($"{n1} {oper} {n2} = {result} - {typ}");
                        break;
                    case "/":
                        Console.WriteLine($"{n1} {oper} {n2} = {result:f2}");
                        break;
                    case "%":
                        Console.WriteLine($"{n1} {oper} {n2} = {result}");
                        break;
                }
            }
        }
    }
}

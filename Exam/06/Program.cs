using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDigit = n % 10;
            int secondDigit = n / 10 % 10;
            int thirdDigit = n / 100;

            for (int i = 1; i <= firstDigit; i++)
            {
                for (int j = 1; j <= secondDigit; j++)
                {
                    for (int k = 1; k <= thirdDigit; k++)
                    {
                        Console.WriteLine("{0} * {1} * {2} = {3};", i, j, k, i * j * k);
                    }
                }
            }
        }
    }
}

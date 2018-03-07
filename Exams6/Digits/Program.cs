using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int thirdDigit = number % 10;
            int secondDigit = number / 10 % 10;
            int firstDigit = number / 100;

            for (int row = 0; row < firstDigit + secondDigit; row++)
            {
                for (int col = 0; col < firstDigit + thirdDigit; col++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= secondDigit;
                    }
                    else
                    {
                        number += thirdDigit;
                    }
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Award
{
    class Program
    {
        static void Main(string[] args)
        {
            var tiles = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());

            var score = 0.0;

            for (int i = 1; i <= tiles; i++)
            {
                var points = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    score += 2 * points;
                else
                    score += points;
            }

            var price = money * score;
            Console.WriteLine("The project prize was {0:f2} lv.", price);
        }
    }
}

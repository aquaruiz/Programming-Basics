using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var length = int.Parse(Console.ReadLine());
            var pieces = width * length;
            var leftPieces = pieces;

            for (int i = 0; i < pieces; i++)
            {
                var input = Console.ReadLine().ToLower();
                if (input == "stop")
                {
                    Console.WriteLine("{0} pieces are left.", leftPieces);
                    i = pieces;
                }
                else
                {
                    leftPieces = leftPieces - int.Parse(input);
                    if (leftPieces < 0)
                    {
                        Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(leftPieces));
                        i = pieces;
                    }
                }                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Uni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var car = 0.0;
            var van = 0.0;
            var miniBus = 0.0;
            var bus = 0.0;
            var train = 0.0;
            var totalPeople = 0;

            for (int i = 0; i < n; i++)
            {
                var group = int.Parse(Console.ReadLine());
                totalPeople += group;
                if (group <= 5)
                    car += group;
                else if (group <= 12)
                    van += group;
                else if (group <= 25)
                    miniBus += group;
                else if (group <= 40)
                    bus += group;
                else if (group >= 41)
                    train += group;
            }
            Console.WriteLine("{0:0.00%}", car / totalPeople);
            Console.WriteLine("{0:0.00%}", van / totalPeople);
            Console.WriteLine("{0:0.00%}", miniBus / totalPeople);
            Console.WriteLine("{0:0.00%}", bus / totalPeople);
            Console.WriteLine("{0:0.00%}", train / totalPeople);
        }
    }
}

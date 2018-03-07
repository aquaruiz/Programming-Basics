using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double trainingDays = double.Parse(Console.ReadLine());
            double startKm = double.Parse(Console.ReadLine());

            double newKms = startKm;
            double runKms = startKm;

            for (int i = 1; i <= trainingDays; i++)
            {
                double increasingPercent = double.Parse(Console.ReadLine());
                newKms += newKms * increasingPercent / 100.0;
                runKms += newKms;
            }
            if (runKms >= 1000)
            {
                Console.WriteLine("You've done a great job running {0:f0} more kilometers!", Math.Ceiling(runKms - 1000));
            }
            else
            {
                Console.WriteLine("Sorry Mrs. Ivanova, you need to run {0:f0} more kilometers", Math.Ceiling(1000 - runKms));
            }
        }
    }
}

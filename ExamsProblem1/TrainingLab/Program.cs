using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var roomLength = double.Parse(Console.ReadLine()) * 100;
            var roomWidth = double.Parse(Console.ReadLine()) * 100;

            var seatsLength = Math.Floor(roomLength / 120);
            var seatsWidth = Math.Floor((roomWidth - 100) / 70);

            var totalSeats = seatsLength * seatsWidth - 3;

            Console.WriteLine(totalSeats);
        }
    }
}

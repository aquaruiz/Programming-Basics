using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleepy_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = int.Parse(Console.ReadLine());

            var workDays = 365 - holidays;
            var playTime = holidays * 127 + workDays * 63;
            var playMore = 30000 - playTime;
            var playHours = playMore / 60;
            var playMinutes = playMore % 60;

            if (playTime <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", Math.Abs(playHours), Math.Abs(playMinutes));
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(playHours), Math.Abs(playMinutes));
            }
        }
    }
}

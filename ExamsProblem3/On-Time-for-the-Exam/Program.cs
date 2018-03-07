using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinute = int.Parse(Console.ReadLine());

            var minsExam = 60 * examHour + examMinute;
            var minsArrival = 60 * arrivalHour + arrivalMinute; 

            if (minsArrival >= (minsExam - 30) && minsArrival <= minsExam)
            {
                Console.WriteLine("On time");
            }
            else if (minsArrival <= minsExam - 30)
            {
                Console.WriteLine("Early");
            }
            else if (minsArrival > minsExam)
            {
                Console.WriteLine("Late");
            }

            if (minsArrival < minsExam)
            {
                if (minsExam - minsArrival < 60)
                {
                        Console.WriteLine("{0} minutes before the start", minsExam - minsArrival);
                }
                else
                {
                    var hours = (minsExam - minsArrival) / 60;
                    var mins = (minsExam - minsArrival) % 60;

                    if (mins < 10)
                        Console.WriteLine("{0}:0{1} hours before the start", hours, mins);
                    else
                        Console.WriteLine("{0}:{1} hours before the start", hours, mins);
                }
            }
            if (minsArrival > minsExam)
                if (minsArrival - minsExam < 60)
                {
                        Console.WriteLine("{0} minutes after the start", minsArrival - minsExam);
                }
            else
            {
                var hours = (minsArrival - minsExam) / 60;
                var mins = (minsArrival - minsExam) % 60;

                if (mins < 10)
                    Console.WriteLine("{0}:0{1} hours after the start", hours, mins);
                else
                    Console.WriteLine("{0}:{1} hours after the start", hours, mins);
            }
        }
    }
}

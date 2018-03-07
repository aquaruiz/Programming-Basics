using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var overnights = int.Parse(Console.ReadLine());

            var apartmentPrice = 0.0;
            var studioPrice = 0.0;

            if (month == "may" || month == "october")
            {
                studioPrice = 50;
                apartmentPrice = 65;
            }
            else if (month == "june" || month == "september")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
            }
            else if (month == "july" || month == "august")
            {
                studioPrice = 76;
                apartmentPrice = 77;
            }

            if (overnights > 7 && overnights <= 14 && (month == "may" || month == "october"))
                studioPrice -= 0.05 * studioPrice;
            else if (overnights > 14 && (month == "may" || month == "october"))
                studioPrice -= 0.30 * studioPrice;
            else if (overnights > 14 && (month == "june" || month == "september"))
                studioPrice -= 0.20 * studioPrice;

            if (overnights > 14)
                apartmentPrice -= 0.10 * apartmentPrice;

            studioPrice = overnights * studioPrice;
            apartmentPrice = overnights * apartmentPrice;

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}

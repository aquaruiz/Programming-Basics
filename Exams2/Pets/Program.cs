using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var kgFood = int.Parse(Console.ReadLine());
            var foodPerDayDogKg = double.Parse(Console.ReadLine());
            var foodPerDayCatKg = double.Parse(Console.ReadLine());
            var foodPerDayTurtleGram = double.Parse(Console.ReadLine());

            var foodDog = days * foodPerDayDogKg;
            var foodCat = days * foodPerDayCatKg;
            var foodTurtle = (days * foodPerDayTurtleGram) / 1000;
            var totalFood = foodDog + foodCat + foodTurtle;

            if (totalFood <= kgFood)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(kgFood - totalFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFood - kgFood));
            }
        }
    }
}

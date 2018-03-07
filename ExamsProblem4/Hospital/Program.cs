using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var treatedPatients = 0;
            var untreatedpatients = 0;
            var doctors = 7;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && (untreatedpatients > treatedPatients))
                {
                    doctors++;
                }
                var patients = int.Parse(Console.ReadLine());
                if (patients <= doctors)
                {
                    treatedPatients += patients;
                }
                else
                {
                    untreatedpatients += patients - doctors;
                    treatedPatients += doctors;
                }
            }

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedpatients);
        }
    }
}

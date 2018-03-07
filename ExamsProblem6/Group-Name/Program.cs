using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            char capital = char.Parse(Console.ReadLine());
            char lowcase1 = char.Parse(Console.ReadLine());
            char lowcase2 = char.Parse(Console.ReadLine());
            char lowcase3 = char.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            int cases = -1;
            for (char i = 'A'; i <= capital; i++)
            {
                for (char j = 'a'; j <= lowcase1; j++)
                {
                    for (char k = 'a'; k <= lowcase2; k++)
                    {
                        for (char l = 'a'; l <= lowcase3; l++)
                        {
                            for (int m = 0; m <= digit; m++)
                            {
                                cases++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(cases);
        }
    }
}

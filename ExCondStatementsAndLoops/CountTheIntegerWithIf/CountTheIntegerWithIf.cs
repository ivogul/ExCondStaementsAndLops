using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegerWithIf
{
    class CountTheIntegerWithIf
    {
        static void Main(string[] args)
        {
            int value = 0;
            int counter = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out value))
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}

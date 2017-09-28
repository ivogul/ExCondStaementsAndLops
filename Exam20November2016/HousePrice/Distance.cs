using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            var initialSpeed = double.Parse(Console.ReadLine());
            var initialKilometers = (initialSpeed / 60) * int.Parse(Console.ReadLine());
            //Console.WriteLine(initialKilometers);
            var ascKilometers = initialSpeed / 60 * 1.1 * int.Parse(Console.ReadLine());
            //Console.WriteLine(ascKilometers);
            var descKilometers = initialSpeed / 60 * 1.1 * 0.95 * int.Parse(Console.ReadLine());
            //Console.WriteLine(descKilometers);
            Console.WriteLine("{0:f2}", initialKilometers + ascKilometers + descKilometers);
        }
    }
}

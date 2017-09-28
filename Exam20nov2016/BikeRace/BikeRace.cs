using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string terain = Console.ReadLine();
            var sum = 0.0;
            if (terain == "trail")
            {
                sum = (juniors * 5.5 + seniors * 7) * 0.95;
            }
            else if (terain == "cross-country")
            {
                if (juniors + seniors >= 50) sum = (juniors * 8 + seniors * 9.5) * 0.75 * 0.95;
                else sum = (juniors * 8 + seniors * 9.5) * 0.95;
            }
            else if (terain == "downhill") sum = (juniors * 12.25 + seniors * 13.75) * 0.95;
            else if (terain == "road") sum = (juniors * 20 + seniors * 21.5) * 0.95;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}

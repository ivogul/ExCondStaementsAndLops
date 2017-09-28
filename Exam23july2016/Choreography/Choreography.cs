using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Choreography
    {
        static void Main(string[] args)
        {
            double steps = double.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            var percentsDay = Math.Ceiling(((steps / days) / steps) * 100);
            //Console.WriteLine(percentsDay);
            if (percentsDay <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", percentsDay / dancers);
            }
            else Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", percentsDay / dancers);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var from0to9 = 0.0;
            var from10to19 = 0.0;
            var from20to29 = 0.0;
            var from30to39 = 0.0;
            var from40to50 = 0.0;
            var invalid = 0.0;
            for (int i = 0; i < steps; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0 || number > 50)
                {
                    invalid++;
                    sum /= 2;
                }
                else if (number >= 0 && number < 10)
                {
                    sum += number * 0.2;
                    from0to9++;
                }
                else if (number >= 10 && number < 20)
                {
                    sum += number * 0.3;
                    from10to19++;
                }
                else if (number >= 20 && number < 30)
                {
                    sum += number * 0.4;
                    from20to29++;
                }
                else if (number >= 30 && number < 40)
                {
                    sum += 50;
                    from30to39++;
                }
                else if (number >= 40 && number <= 50)
                {
                    sum += 100;
                    from40to50++;
                }
            }
            Console.WriteLine("{0:f2}", sum);
            Console.WriteLine("From 0 to 9: {0:f2}%", from0to9 / steps * 100);
            Console.WriteLine("From 10 to 19: {0:f2}%", from10to19 / steps * 100);
            Console.WriteLine("From 20 to 29: {0:f2}%", from20to29 / steps * 100);
            Console.WriteLine("From 30 to 39: {0:f2}%", from30to39 / steps * 100);
            Console.WriteLine("From 40 to 50: {0:f2}%", from40to50 / steps * 100);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalid / steps * 100);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            var stadionCapacity = int.Parse(Console.ReadLine());
            var aCount = 0.0;
            var bCount = 0.0;
            var vCount = 0.0;
            var gCount = 0.0;
            var fansCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= fansCount; i++)
            {
                var sector = char.Parse(Console.ReadLine());
                if (sector == 'A') aCount++;
                else if (sector == 'B') bCount++;
                else if (sector == 'V') vCount++;
                else if (sector == 'G') gCount++;
            }
            var allFans = aCount + bCount + vCount + gCount;
            Console.WriteLine("{0:f2}%", aCount / allFans * 100);
            Console.WriteLine("{0:f2}%", bCount / allFans * 100);
            Console.WriteLine("{0:f2}%", vCount / allFans * 100);
            Console.WriteLine("{0:f2}%", gCount / allFans * 100);
            Console.WriteLine("{0:f2}%", allFans / stadionCapacity * 100);
        }
    }
}

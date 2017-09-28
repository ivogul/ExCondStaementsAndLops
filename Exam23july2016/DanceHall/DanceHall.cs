using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeLength = double.Parse(Console.ReadLine());
            var area = (length * 100) * (width * 100);
            var totalArea = area * 0.9 - ((wardrobeLength * 100) * (wardrobeLength * 100));
            var dancersCount = Math.Floor(totalArea / 7040);
            Console.WriteLine("{0}", dancersCount);
        }
    }
}

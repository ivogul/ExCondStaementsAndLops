using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileRepair
{
    class TileRepair
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var o = int.Parse(Console.ReadLine());
            var area = n * n;
            //Console.WriteLine(area);
            var tileArea = w * l;
            //Console.WriteLine(tileArea);
            var benchArea = m * o;
            //Console.WriteLine(benchArea);
            var tileNeeded = (area - benchArea) / tileArea;
            var time = tileNeeded * 0.2;
            Console.WriteLine("{0:f2}", tileNeeded);
            Console.WriteLine("{0:f2}", time);

        }
    }
}

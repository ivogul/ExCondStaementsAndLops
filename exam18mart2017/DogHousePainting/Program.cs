using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            var sideWallArea = a * (a / 2);
            //Console.WriteLine(sideWallArea);
            var backWallSquare = (a / 2) * (a / 2);
            var backWallTriangle = (a / 2) * (b - (a / 2)) / 2;
            var backWallArea = backWallSquare + backWallTriangle;
            //Console.WriteLine(backWallArea);
            var frontWallArea = backWallArea - ((a / 5) * (a / 5));
            //Console.WriteLine(frontWallArea);
            var wallArea = 2 * sideWallArea + backWallArea + frontWallArea;
            var roofArea = 2 * (a * (a / 2));
            var greenPaint = wallArea / 3;
            var redPaint = roofArea / 5;
            Console.WriteLine("{0:f2}", greenPaint);
            Console.WriteLine("{0:f2}", redPaint);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            double hrizCount = double.Parse(Console.ReadLine());
            double roseCount = double.Parse(Console.ReadLine());
            double laleCount = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            //var hrizPice = 0.0;
            //var rosePrice = 0.0;
            //var lalePrice = 0.0;
            var sum = 0.0;
            if (season == "Spring" || season == "Summer")
            {
                var hrizPrice = 2 * hrizCount;
                var rosePrice = 4.1 * roseCount;
                var lalePrice = 2.5 * laleCount;
                sum = hrizPrice + rosePrice + lalePrice;
            }
            else
            {
                var hrizPrice = 3.75 * hrizCount;
                var rosePrice = 4.5 * roseCount;
                var lalePrice = 4.15 * laleCount;
                sum = hrizPrice + rosePrice + lalePrice;
            }
            //var sum = (hrizPice * hrizCount) + (rosePrice * roseCount) + (lalePrice * laleCount);
            if (holiday == "Y") sum *= 1.15;
            if (season == "Spring" && laleCount > 7) sum *= 0.95;
            if (season == "Winter" && roseCount >= 10) sum *= 0.90;
            if (hrizCount + roseCount + laleCount > 20) sum *= 0.80;
            sum += 2;

            Console.WriteLine("{0:f2}", sum);
        }
    }
}

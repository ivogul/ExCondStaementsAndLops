using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            //var price = 0;
            var bussWeight = 0;
            var truckWeight = 0;
            var trainWeight = 0;
            for (int i = 1; i <= count; i++)
            {
                int weight = int.Parse(Console.ReadLine());
                if (weight <= 3) bussWeight += weight;
                else if (weight >= 4 && weight < 12) truckWeight += weight;
                else trainWeight += weight;
            }
            double sumWeight = bussWeight + truckWeight + trainWeight;
            Console.WriteLine("{0:f2}", (bussWeight * 200 + truckWeight * 175 + trainWeight * 120) / sumWeight);
            Console.WriteLine("{0:f2}%", bussWeight / sumWeight * 100);
            Console.WriteLine("{0:f2}%", truckWeight / sumWeight * 100);
            Console.WriteLine("{0:f2}%", trainWeight / sumWeight * 100);
        }
    }
}

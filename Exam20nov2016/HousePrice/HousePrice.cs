using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            double smallRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double sqMeterPrice = double.Parse(Console.ReadLine());
            var bathroom = smallRoom / 2;
            var secondRoom = smallRoom * 1.1;
            var thirdRoom = secondRoom * 1.1;
            var area = (smallRoom + kitchen + bathroom + secondRoom + thirdRoom) * 1.05;
            Console.WriteLine("{0:f2}", area * sqMeterPrice);
        }
    }
}

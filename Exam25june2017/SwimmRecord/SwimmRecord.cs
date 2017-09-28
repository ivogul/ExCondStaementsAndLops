using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmRecord
{
    class SwimmRecord
    {
        static void Main(string[] args)
        {
            double worldRecordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeForMeter = double.Parse(Console.ReadLine());
            var waterResistance = Math.Floor(distanceInMeters / 15) * 12.5;
            var timeForDistance = distanceInMeters * timeForMeter + waterResistance;

            if (timeForDistance < worldRecordInSeconds)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", timeForDistance);
            }
            else Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", timeForDistance - worldRecordInSeconds);
        }
    }
}

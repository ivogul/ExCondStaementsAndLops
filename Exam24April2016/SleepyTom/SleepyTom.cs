using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTom
{
    class SleepyTom
    {
        static void Main(string[] args)
        {
            var restDays = int.Parse(Console.ReadLine());
            var workDays = 365 - restDays;
            var playTime = workDays * 63 + (restDays * 127);
            if (playTime <= 30000)
            {
                var timeLeft = 30000 - playTime;
                var hous = timeLeft / 60;
                var minutes = timeLeft % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hous, minutes);
            }
            else if (playTime > 30000)
            {
            var timeNeeded = playTime - 30000;
                var hoursNeeded = timeNeeded / 60;
                var minutesNeeded = timeNeeded % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hoursNeeded, minutesNeeded);
            }
        }
    }
}

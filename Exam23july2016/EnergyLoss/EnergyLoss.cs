using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyLoss
{
    class EnergyLoss
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine()); //training days count
            int a = int.Parse(Console.ReadLine()); //dancers
            var energyLost = 0.0;
            for (int i = 1; i <= n; i++)
            {
                int hoursTraining = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && hoursTraining % 2 == 0) energyLost += a * 68;
                else if (i % 2 != 0 && hoursTraining % 2 == 0) energyLost += a * 49;
                else if (i % 2 == 0 && hoursTraining % 2 != 0) energyLost += a * 65;
                else if (i % 2 != 0 && hoursTraining % 2 != 0) energyLost += a * 30;

            }
            var energyTotal = a * n * 100;
            //Console.WriteLine(energyTotal);
            var savedEnergy = energyTotal - energyLost;
            //Console.WriteLine(savedEnergy);
            var savedEnergyPerDancer = savedEnergy / a / n;
            //Console.WriteLine(savedEnergyPerDancer);
            if (savedEnergyPerDancer >= 50)
            {
                Console.WriteLine("They feel good! Energy left: {0:f2}", savedEnergyPerDancer);
            }
            else if (savedEnergyPerDancer < 50) Console.WriteLine("They are wasted! Energy left: {0:f2}", savedEnergyPerDancer);
        }
    }
}

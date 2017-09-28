using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyPrice
{
    class MoneyPrice
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double moneyPerPoint = double.Parse(Console.ReadLine());
            int points = 0;
            var prize = 0.0;
            var sum = 0.0;
            for (int i = 1; i <= parts; i++)
            {
                points = int.Parse(Console.ReadLine());
                prize = points * moneyPerPoint;
                if (i % 2 == 0) prize *= 2;
                sum += prize;
            }
            Console.WriteLine("The project prize was {0:f2} lv.", sum);

        }
    }
}

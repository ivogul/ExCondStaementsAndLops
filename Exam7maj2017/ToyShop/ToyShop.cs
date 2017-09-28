using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            var vacationPrice = double.Parse(Console.ReadLine());
            var puzzleCount = int.Parse(Console.ReadLine());
            var dollCount = int.Parse(Console.ReadLine());
            var bearCount = int.Parse(Console.ReadLine());
            var minionCount = int.Parse(Console.ReadLine());
            var truckCount = int.Parse(Console.ReadLine());
            var sum = (puzzleCount * 2.6) + (dollCount * 3) + (bearCount * 4.1) + (minionCount * 8.2) + (truckCount * 2);
            if (puzzleCount + dollCount + bearCount + minionCount + truckCount >= 50) sum *= 0.75;
            var total = sum * 0.9;
            if (total >= vacationPrice)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", total - vacationPrice);
            }
            else if (total < vacationPrice) Console.WriteLine("Not enough money! {0:f2} lv needed.", vacationPrice - total);
        }
    }
}

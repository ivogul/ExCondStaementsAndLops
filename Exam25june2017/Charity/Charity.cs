using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity
{
    class Charity
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int tortes = int.Parse(Console.ReadLine());
            int gofrettes = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double moneyPerDayPerBaker = (tortes * 45) + (gofrettes * 5.8) + (pancakes * 3.2);
            var sum = moneyPerDayPerBaker * bakers * days / 8 * 7;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}

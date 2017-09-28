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
            int magnCount = int.Parse(Console.ReadLine());
            int zumbulCount = int.Parse(Console.ReadLine());
            int roseCount = int.Parse(Console.ReadLine());
            int cactusCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            var sum = (magnCount * 3.25 + zumbulCount * 4.0 + roseCount * 3.5 + cactusCount * 8) * 0.95;
            if (sum >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(sum - giftPrice));
            }
            else Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - sum));
        }
    }
}

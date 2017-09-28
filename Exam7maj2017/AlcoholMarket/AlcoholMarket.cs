using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMarket
{
    class AlcoholMarket
    {
        static void Main(string[] args)
        {
            var priceWhisky = double.Parse(Console.ReadLine());
            var biraQuantity = double.Parse(Console.ReadLine());
            var wineQuantity = double.Parse(Console.ReadLine());
            var rakiaQuantity = double.Parse(Console.ReadLine());
            var whiskyQuantity = double.Parse(Console.ReadLine());
            var priceRakia = priceWhisky / 2;
            var priceWine = priceRakia * 0.6;
            var priceBira = priceRakia * 0.2;
            var total = (priceWhisky * whiskyQuantity) + (priceBira * biraQuantity) + (priceWine * wineQuantity) + (priceRakia * rakiaQuantity);
            Console.WriteLine("{0:f2}", total);
        }
    }
}

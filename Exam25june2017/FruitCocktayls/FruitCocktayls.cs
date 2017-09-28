using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCocktayls
{
    class FruitCocktayls
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var quantity = Console.ReadLine();
            var orders = int.Parse(Console.ReadLine());
            var pricePerLitre = 0.0;
            var sum = 0.0;
            if (fruit == "Watermelon")
            {
                if (quantity == "small") pricePerLitre = 56;
                else if (quantity == "big") pricePerLitre = 28.7;
            }
            else if (fruit == "Mango")
            {
                if (quantity == "small") pricePerLitre = 36.66;
                else if (quantity == "big") pricePerLitre = 19.6;
            }
            else if (fruit == "Pineapple")
            {
                if (quantity == "small") pricePerLitre = 42.1;
                else if (quantity == "big") pricePerLitre = 24.8;
            }
            else if (fruit == "Raspberry")
            {
                if (quantity == "small") pricePerLitre = 20;
                else if (quantity == "big") pricePerLitre = 15.2;
            }

            if (quantity == "small") sum = pricePerLitre * 2;
            else if (quantity == "big") sum = pricePerLitre * 5;

            var total = sum * orders;

            if (total > 1000) total /= 2;
            else if (total >= 400 && total < 1000) total *= 0.85;
            Console.WriteLine("{0:f2} lv.", total);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            var hallName = "Small Hall";
            var hallPrice = 2500;
            var discount = 0.95;
            var discountPrice = 500;
                if (package == "Gold")
                {
                    discount = 0.9;
                    discountPrice = 750;
                }
                else if (package == "Platinum")
                {
                    discount = 0.85;
                    discountPrice = 1000;
                }
            if (groupSize <= 50)
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine("The price per person is {0:f2}$", (hallPrice + discountPrice) * discount / groupSize);
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
                hallPrice = 5000;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine("The price per person is {0:f2}$", (hallPrice + discountPrice) * discount / groupSize);
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine("The price per person is {0:f2}$", (hallPrice + discountPrice) * discount / groupSize);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}

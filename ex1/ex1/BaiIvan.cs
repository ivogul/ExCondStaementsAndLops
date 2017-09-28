using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiIvan
{
    class BaiIvan
    {
        static void Main(string[] args)
        {
            var dayOfWeek = int.Parse(Console.ReadLine());
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            decimal alcoholWanted = decimal.Parse(Console.ReadLine());
            decimal price = 0.0m;
            if (dayOfWeek == 0) price = 25.0m;
            else if (dayOfWeek == 1) price = 21.0m;
            else if (dayOfWeek == 2) price = 14.0m;
            else if (dayOfWeek == 3) price = 17.0m;
            else if (dayOfWeek == 4) price = 45.0m;
            else if (dayOfWeek == 5) price = 59.0m;
            else if (dayOfWeek == 6) price = 42.0m;

            decimal amountPurchased = amountOfMoney / price;

            var condition = "drunk";
            if (amountPurchased > 1.5m) condition = "very drunk";
            else if (amountPurchased < 1.0m) condition = "sober";

            if (amountPurchased > alcoholWanted) Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1}l.of alcohol with his friends", condition, (amountPurchased - alcoholWanted));
            else if (amountPurchased < alcoholWanted) Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1}l.of alcohol", condition, (alcoholWanted - amountPurchased));
            else Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);



        }
    }
}

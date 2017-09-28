using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromotionsWithSwitchCase
{
    class TheatrePromotionsWithSwitchCase
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int visitorsAge = int.Parse(Console.ReadLine());
            int childrenPrice = 0;
            int adultPrice = 0;
            int seniorPrice = 0;

            switch (dayType)
            {
                case "Weekday":
                    childrenPrice = 12;
                    adultPrice = 18;
                    seniorPrice = 12;
                    break;
                case "Weekend":
                    childrenPrice = 15;
                    adultPrice = 20;
                    seniorPrice = 15;
                    break;
                case "Holiday":
                    childrenPrice = 5;
                    adultPrice = 12;
                    seniorPrice = 10;
                    break;
            }
            if (visitorsAge >= 0 && visitorsAge <= 18) Console.WriteLine($"{childrenPrice}$");
            else if (visitorsAge > 18 && visitorsAge <= 64) Console.WriteLine($"{adultPrice}$");
            else if (visitorsAge > 64 && visitorsAge <= 122) Console.WriteLine($"{seniorPrice}$");
            else Console.WriteLine("Error!");
        }
 
    }
}

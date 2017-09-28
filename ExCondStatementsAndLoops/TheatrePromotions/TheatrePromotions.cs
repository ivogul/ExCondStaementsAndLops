using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromotions
{
    class TheatrePromotions
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <=18)
            {
                if (dayType == "Weekday") Console.WriteLine("12$");
                else if (dayType == "Weekend") Console.WriteLine("15$");
                else if (dayType == "Holiday") Console.WriteLine("5$");
            }
            else if (age > 18 && age <= 64)
            {
                if (dayType == "Weekday") Console.WriteLine("18$");
                else if (dayType == "Weekend") Console.WriteLine("20$");
                else if (dayType == "Holiday") Console.WriteLine("12$");
            }
            else if (age > 64 && age <= 122)
            {
                if (dayType == "Weekday") Console.WriteLine("12$");
                else if (dayType == "Weekend") Console.WriteLine("15$");
                else if (dayType == "Holiday") Console.WriteLine("10$");
            }
            else Console.WriteLine("Error!");
        }
    }
}

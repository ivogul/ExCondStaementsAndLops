using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolCamp
{
    class ScoolCamp
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var group = Console.ReadLine();
            var studentsCount = int.Parse(Console.ReadLine());
            var nightsCount = int.Parse(Console.ReadLine());
            var price = 0.0;
            string sport = "Judo";
            if (season == "Winter")
            {
                if (group == "boys")
                {
                    sport = "Judo";
                    price = 9.6;
                }
                else if (group == "girls")
                {
                    sport = "Gymnastics";
                    price = 9.6;
                }
                else if (group == "mixed")
                {
                    sport = "Ski";
                    price = 10;
                }
            }
            else if (season == "Spring")
            {
                if (group == "boys")
                {
                    sport = "Tennis";
                    price = 7.2;
                }
                else if (group == "girls")
                {
                    sport = "Athletics";
                    price = 7.2;
                }
                else if (group == "mixed")
                {
                    sport = "Cycling";
                    price = 9.5;
                }
            }
            else if (season == "Summer")
            {
                if (group == "boys")
                {
                    sport = "Football";
                    price = 15;
                }
                else if (group == "girls")
                {
                    sport = "Volleyball";
                    price = 15;
                }
                else if (group == "mixed")
                {
                    sport = "Swimming";
                    price = 20;
                }
            }
            var sum = price * studentsCount * nightsCount;
            if (studentsCount >= 50) sum *= 0.5;
            else if (studentsCount >= 20 && studentsCount < 50) sum *= 0.85;
            else if (studentsCount >= 10 && studentsCount < 20) sum *= 0.95;
            Console.WriteLine("{0} {1:f2} lv.", sport, sum);
        }
    }
}

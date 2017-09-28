using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCompetition
{
    class FinalCompetition
    {
        static void Main(string[] args)
        {
            int dancersCount = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            var priceMoney = 0.0;
            if (place == "Bulgaria")
            {
                if (season == "winter") priceMoney = dancersCount * points * 0.92;
                else if (season == "summer") priceMoney = dancersCount * points * 0.95;
            }
            else if (place == "Abroad")
            {
                if (season == "winter") priceMoney = dancersCount * points * 1.5 * 0.85;
                else if (season == "summer") priceMoney = dancersCount * points * 1.5 * 0.90;
            }
            var charity = priceMoney * 0.75;
            Console.WriteLine("Charity - {0:f2}", charity);
            Console.WriteLine("Money per dancer - {0:f2}", (priceMoney - charity) / dancersCount);
        }
    }
}

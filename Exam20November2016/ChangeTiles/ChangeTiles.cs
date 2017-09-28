using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            var savedMoney = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var lenght = double.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var priceTile = double.Parse(Console.ReadLine());
            var labor = double.Parse(Console.ReadLine());
            var area = width * lenght;
            //Console.WriteLine(area);
            var tileArea = a * h / 2;
            //Console.WriteLine(tileArea);
            var tilesNeeded = Math.Ceiling(area / tileArea) + 5;
            //Console.WriteLine(tilesNeeded);
            var moneyNeeded =  tilesNeeded * priceTile + labor;
            //Console.WriteLine(moneyNeeded);
            if (moneyNeeded <= savedMoney)
            {
                Console.WriteLine("{0:f2} lv left.", savedMoney - moneyNeeded);
            }
            else Console.WriteLine("You'll need {0} lv more.", moneyNeeded - savedMoney);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            string drink = "Tea";
            if (profession == "Athlete") drink = "Water";
            else if (profession == "SoftUni Student") drink = "Beer";
            else if (profession == "Businessman" || profession == "Businesswoman") drink = "Coffee";
            Console.WriteLine(drink);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            string drink = "Tea";
            var price = 1.2;
            if (profession == "Athlete") {
                drink = "Water";
                price = 0.7;
            }
            else if (profession == "SoftUni Student") {
                drink = "Beer";
                price = 1.7;
            }
            else if (profession == "Businessman" || profession == "Businesswoman") {
                drink = "Coffee";
                price = 1.0;
            }
            var totalPrice = price * quantity;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}

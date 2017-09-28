using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; i <= 20; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", counter);
                    break;
                }
                else
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;
            }
        }
    }
}

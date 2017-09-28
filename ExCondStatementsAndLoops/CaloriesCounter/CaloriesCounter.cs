using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCaloriesAmount = 0;
            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient == "cheese") totalCaloriesAmount += 500;
                else if (ingredient == "tomato sauce") totalCaloriesAmount += 150;
                else if (ingredient == "salami") totalCaloriesAmount += 600;
                else if (ingredient == "pepper") totalCaloriesAmount += 50;
            }
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}

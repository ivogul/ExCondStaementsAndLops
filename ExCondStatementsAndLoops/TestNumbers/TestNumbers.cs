using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());
            int sum = 0;
            int countOfCombinations = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    int temp = i * j * 3;
                    sum += temp;
                    countOfCombinations++;
                    if (sum >= maxSumBoundary) break;
                }
                if (sum >= maxSumBoundary) break;
            }
            if (sum >= maxSumBoundary)
            {
                Console.WriteLine($"{countOfCombinations} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSumBoundary}");
            }
            else
            {
                Console.WriteLine($"{countOfCombinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}

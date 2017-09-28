using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int magicN = 0;
            int magicM = 0;
            int combinations = 0;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magicNumber)
                    {
                        magicN = i;
                        magicM = j;
                    }
                    combinations++;
                }
            }
            if (magicN > 0)
            {
                Console.WriteLine($"Number found! {magicN} + {magicM} = {magicNumber}");
            }
            else Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinations
{
    class MaxCombinations
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    Console.Write("<{0}-{1}>", i, j);
                    count++;
                    if (count >= max) break;
                }
                if (count >= max) break;
            }
            Console.WriteLine();
        }
    }
}

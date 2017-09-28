using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a + 5 > b) Console.WriteLine("No");
            else
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = a + 1; j <= b; j++)
                    {
                        for (int k = j + 1; k <= b; k++)
                        {
                            for (int l = k + 1; l <= b; l++)
                            {
                                for (int m = l + 1; m <= b; m++)
                                {
                                    if (i < j && j < k && k < l && l < m)
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

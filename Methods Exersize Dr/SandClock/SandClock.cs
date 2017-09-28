using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandClock
{
    class SandClock
    {
        static void DrawSandClock(int n)
        {
            for (int i = n; i > 1; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            DrawSandClock(num);
        }
    }
}

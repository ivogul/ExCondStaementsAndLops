using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Pyramid
    {
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i-1 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n - 1; j >= i; j--)
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
            int n = int.Parse(Console.ReadLine());
            DrawPyramid(n);
        }
    }
}

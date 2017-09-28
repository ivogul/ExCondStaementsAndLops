using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n * 2; i++)
            {
                //Draw dots
                Console.Write(new string('.', (n * 2 - 1 - i) * 3));
                //Draw "#"
                Console.Write(new string('#', i * 3) + "#" + new string('#', i * 3));
                //Draw dots
                Console.WriteLine(new string('.', (n * 2 - 1 - i) * 3));
            }

            for (int i = 1; i <= n - 2; i++)
            {
                //Draw dots
                Console.Write("|" + new string('.', i * 3 - 1));
                //Draw "#"
                //Console.Write(new string('#', (n * 2 - 1 - i) * 3) + "#" + new string('#', (n * 2 - 1 - i) * 3));
                Console.Write(new string('#', (n * 2 - 1 - i) * 6 + 1));
                //Draw dots
                Console.WriteLine(new string('.', i * 3));
            }

            for (int i = 0; i < n; i++)
            {
                //Draw dots
                if (i == n - 1) Console.Write("@");
                else Console.Write("|");
                Console.Write(new string('.', (n - 1) * 3 - 1));
                //Draw "#"
                Console.Write(new string('#', n * 6 + 1));
                //Draw dots
                Console.WriteLine(new string('.', (n - 1) * 3));
            }
        }
    }
}

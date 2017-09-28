using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('#', (4 * n) + 1));
            for (int i = 1; i <= n; i++)
            {
                //First half
                //Draw dots
                Console.Write(new string('.', i));
                //Draw #
                Console.Write(new string('#', n - i) + "#" + new string('#', n - i));
                //Draw " "
                if (i == n / 2 + 1) Console.Write(new string(' ', i - 2) + "(@)" + new string(' ', i - 2));
                else Console.Write(new string(' ', i - 1) + " " + new string(' ', i - 1));
                //Draw #
                Console.Write(new string('#', n - i) + "#" + new string('#', n - i));
                //Draw dots
                Console.WriteLine(new string('.', i));
            }
            //second half
            for (int i = 1; i <= n; i++)
            {
                //Draw dots
                Console.Write(new string('.', n + i));
                //Draw "#"
                Console.Write(new string('#', n - i) + "#" + new string('#', n - i));
                //Draw dots
                Console.WriteLine(new string('.', n + i));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Crown
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("@" + new string(' ', n -2) + "@" + new string(' ', n - 2) + "@");
            for (int i = 0; i <= n / 2; i++)
            {
                if (i == 0) Console.WriteLine("**" + new String(' ', n -3) + "*" + new String(' ', n - 3) + "**");
                else if (i == n / 2 - 1) Console.WriteLine("*" + new string('.', i) + "*" + new string('.', n - 3) + "*" + new string('.', i) + "*");
                else if (i == n / 2) Console.WriteLine("*" + new string('.', i) + new string('*', i - 2) + "." + new string('*', i - 2) + new string('.', i) + "*");
                else Console.WriteLine("*" + new string('.', i) + "*" + new string(' ', n - 3 - (i * 2)) + "*" + new string('.', i + (i - 1)) + "*" + new string(' ', n - 3 - (i * 2)) + "*" + new string('.', i) + "*");
                //else Console.WriteLine("*" + new String('.', 2 * n - 3) + "*");
            }
            Console.WriteLine(new String('*', 2 * n -1));
            Console.WriteLine(new String('*', 2 * n - 1));
        }
    }
}

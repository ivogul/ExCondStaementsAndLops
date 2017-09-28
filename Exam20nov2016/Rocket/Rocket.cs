using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new String('.', 3 * n /2 - 1 - i) + "/" + new String(' ', i * 2) + "\\" + new String('.', 3 * n / 2 - 1 - i));
            }
            Console.WriteLine(new String('.', n / 2) + new string('*', 2 * n) + new String('.', n / 2));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine(new String('.', n / 2) + "|" + new string('\\', 2 * n - 2) + "|" + new String('.', n / 2));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new String('.', n / 2 - i) + "/" + new string('*', (2 * n - 2) + 2 * i) + "\\" + new String('.', n / 2 - i));
            }
        }
    }
}

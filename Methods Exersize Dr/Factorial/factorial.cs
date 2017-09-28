using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class factorial
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = Factorial(n);
            Console.WriteLine("{0}! = {1}", n, factorial);
        }
        static decimal Factorial(int n)
        {
            // The bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            // Recursive call: the method calls itself
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}

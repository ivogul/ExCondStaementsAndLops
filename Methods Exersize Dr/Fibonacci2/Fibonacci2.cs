using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    class Fibonacci2
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
                int sum = 0;
            Console.Write(sum);
            int firstFib = 0;
            int secondFib = 1;
            for (int i = 1; i <= num; i++)
            {
                sum = firstFib + secondFib;
                Console.Write(", " + sum);
                firstFib = sum;
                secondFib = 
                
            }
            Console.WriteLine();
        }
    }
}

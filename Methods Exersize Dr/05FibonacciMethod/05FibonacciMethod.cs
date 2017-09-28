using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05FibonacciMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibNumber = Fib(n);
            Console.WriteLine(fibNumber);
        }
        static int Fib(int n)
        {
            int firstNum = 0, secondNum = 1, 
                sum = firstNum + secondNum;
            for (int i = 0; i <= n; i++)
            {
                
                firstNum = secondNum;
                secondNum = sum;

            }
            return sum;
        }
    }
}

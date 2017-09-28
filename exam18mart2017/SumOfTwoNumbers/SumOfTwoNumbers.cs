using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;
            int firstNumber = 0;
            int secondNumber = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    sum = i + j;
                    firstNumber = i;
                    secondNumber = j;
                    combinations++;
                    if (sum == magicNumber) break;
                 }
                if (sum == magicNumber) break;
            }

            if (sum == magicNumber)
            {
                Console.WriteLine("Combination N: {0} ({1} + {2} = {3})", combinations, firstNumber, secondNumber, sum);
            }
            else Console.WriteLine("{0} combinations - neither equals {1}", combinations, magicNumber);
        }
    }
}

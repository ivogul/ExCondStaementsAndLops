using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = NumbersInReversedOrder(input);
            Console.WriteLine(output);
        }
        static string NumbersInReversedOrder(string input)
         {
            char[] decimalInput = input.ToCharArray();
           Array.Reverse(decimalInput);
            return new string(decimalInput);
           }
    }

}

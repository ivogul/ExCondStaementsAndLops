using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            if (two < one)
            {
                int temp = one;
                one = two;
                two = temp;
            }
            for (int i = one; i <= two; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

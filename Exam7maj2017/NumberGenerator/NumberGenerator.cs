using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    class NumberGenerator
    {
        static void Main(string[] args)
        {
            var mfirst = int.Parse(Console.ReadLine());
            var nsecond = int.Parse(Console.ReadLine());
            var lthird = int.Parse(Console.ReadLine());
            var specialNumber = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
            for (int i = mfirst; i >= 1; i--)
            {
                for (int j = nsecond; j >= 1; j--)
                {
                    for (int k = lthird; k >= 1; k--)
                    {
                        var num = i * 100 + (j * 10) + k;
                        if (num % 3 == 0) specialNumber += 5;
                        else if (num % 10 == 5) specialNumber -= 2;
                        else if (num % 2 == 0) specialNumber *= 2;

                        if (specialNumber >= controlNumber) break;

                    }
                    if (specialNumber >= controlNumber) break;
                }
                if (specialNumber >= controlNumber) break;
            }
            if (specialNumber >= controlNumber)
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
            }
            else Console.WriteLine("No! {0} is the last reached special number.", specialNumber);
        }
    }
}

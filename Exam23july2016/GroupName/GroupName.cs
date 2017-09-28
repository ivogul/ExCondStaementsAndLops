using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupName
{
    class GroupName
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            char forth = char.Parse(Console.ReadLine());           
            int digit = int.Parse(Console.ReadLine());
            var counter = 0;
            for (char i = 'A'; i <= first; i++)
            {
                for (char j = 'a'; j <= second; j++)
                {
                    for (char k = 'a'; k <= third; k++)
                    {
                        for (char l = 'a'; l <= forth; l++)
                        {
                            for (int num = 0; num <= digit; num++)
                            {
                                if (i == first && j == second && k == third && l == forth && num == digit) break;
                                //Console.Write("{0}{1}{2}{3}{4} ", i, j, k, l, num);
                                counter++;

                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}

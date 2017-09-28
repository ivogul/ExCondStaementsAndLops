using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char first = Convert.ToChar(Console.ReadLine());
            char second = Convert.ToChar(Console.ReadLine());
            char third = Convert.ToChar(Console.ReadLine());
            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        if (i != third && j != third && k != third) Console.Write($"{i}{j}{k} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

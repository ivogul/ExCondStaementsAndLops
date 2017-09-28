using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    break;
                    //throw;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

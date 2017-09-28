using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOrMultiply
{
    class AddOrMultiply
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var flag = false;
            for (int i = 1; i <= 30; i++)
            {
                for (int j = i + 1; j <= 30; j++)
                {
                    for (int k = j + 1; k <= 30; k++)
                    {
                        if ((i + j + k) == num)
                        {
                            flag = true;
                                Console.WriteLine("{0} + {1} + {2} = {3}", i, j, k, num);
                        }
                    }
                }
            }
            for (int i = 3; i <= 30; i++)
            {
                for (int j = 2; j <= i - 1; j++)
                {
                    for (int k = 1; k <= j - 1; k++)
                    {
                        if (i * j * k == num)
                        {
                            flag = true;
                            Console.WriteLine("{0} * {1} * {2} = {3}", i, j, k, num);
                        }
                    }
                }
            }
            if (flag == false) Console.WriteLine("No!");
        }
    }
}

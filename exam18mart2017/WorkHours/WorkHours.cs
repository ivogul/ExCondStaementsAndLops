using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int manHours = workers * workingDays * 8;
            if (manHours <= neededHours)
            {
                Console.WriteLine("{0} hours left", neededHours - manHours);
            }
            else
            {
                Console.WriteLine("{0} overtime", manHours - neededHours);
                Console.WriteLine("Penalties: {0}", (manHours - neededHours) * workingDays);
            }
        }
    }
}

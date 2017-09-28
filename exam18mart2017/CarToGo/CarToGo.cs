using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string typeClass = "Economy Class";
            string carClass = "Cabrio";
            double price = 0;

            if (budget <= 100)
            {
                //typeClass = "Economy Class";
                if (season == "Summer")
                {
                    //carClass = "Cabrio";
                    price = budget * .35;
                }

                else if (season == "Winter")
                {
                    carClass = "Jeep";
                    price = budget * .65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                typeClass = "Compact Class";
                if (season == "Summer")
                {
                    //carClass = "Cabrio";
                    price = budget * .45;
                }

                else if (season == "Winter")
                {
                    carClass = "Jeep";
                    price = budget * .8;
                }
            }
            
            else if (budget > 500)
            {
                typeClass = "Luxury Class";
                    carClass = "Jeep";
                    price = budget * .90;
                
            }
            Console.WriteLine("{0}", typeClass);
            Console.WriteLine("{0} - {1:f2}", carClass, price);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMarto223
{
    class HotelMarto223
    {
        static void Main(string[] args)
        {
                string month = Console.ReadLine();
                int nights = int.Parse(Console.ReadLine());
                if (month == "May" && nights > 7)
                {
                    Console.WriteLine($"Studio: {(nights * 50 * 0.95):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 65):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 75):f2} lv.");
                }
                else if (month == "May" && nights < 7)
                {
                    Console.WriteLine($"Studio: {(nights * 50):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 65):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 75):f2} lv.");
                }
                else if (month == "October" && nights > 7)
                {
                    Console.WriteLine($"Studio: {(50 * 0.95 * (nights - 1)):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 65):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 75):f2} lv.");
                }
                else if (month == "October" && nights < 7)
                {
                    Console.WriteLine($"Studio: {(nights * 50):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 65):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 75):f2} lv.");
                }
                else if (month == "June" && nights > 14)
                {
                    Console.WriteLine($"Studio: {(nights * 60)} lv.");
                    Console.WriteLine($"Double: {(nights * 72 * 0.9)} lv.");
                    Console.WriteLine($"Suite: {(nights * 82):f2} lv.");
                }
                else if (month == "June" && nights < 14)
                {
                    Console.WriteLine($"Studio: {(nights * 60):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 72):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 82):f2} lv.");
                }
                else if (month == "September" && nights < 14)
                {
                    if (nights > 7) Console.WriteLine($"Studio: {(nights * 60 - 60):f2} lv.");
                    else Console.WriteLine($"Studio: {(nights * 60):f2} lv.");
                Console.WriteLine($"Double: {(nights * 72):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 82):f2} lv.");
                }
                else if (month == "September" && nights > 14)
                {
                    Console.WriteLine($"Studio: {(nights * 60 - 60):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 72 * 0.9):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 82):f2} lv.");
                }
                else if (month == "July" && nights > 14)
                {
                    Console.WriteLine($"Studio: {(nights * 68):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 77):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 89 * 0.85):f2} lv.");
                }
                else if (month == "July" && nights < 14)
                {
                    Console.WriteLine($"Studio: {(nights * 68):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 77):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 89):f2} lv.");
                }

                else if (month == "August" && nights > 14)
                {
                    Console.WriteLine($"Studio:   {(nights * 68):f2} lv.");
                    Console.WriteLine($"Double:  {(nights * 77):f2} lv.");
                    Console.WriteLine($"Suite:  {(nights * 89 * 0.85):f2} lv.");
                }
                else if (month == "August" && nights < 14)
                {
                    Console.WriteLine($"Studio:  {(nights * 68):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 77):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 89):f2} lv.");
                }
                else if (month == "December" && nights > 14)
                {
                    Console.WriteLine($"Studio: {(nights * 68):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 77):f2} lv.");
                    Console.WriteLine($"Suite: {(nights * 89 * 0.85):f2} lv.");
                }
                else if (month == "December" && nights < 14)
                {
                    Console.WriteLine($"Studio: {(nights * 68):f2} lv.");
                    Console.WriteLine($"Double: {(nights * 77)} lv.");
                    Console.WriteLine($"Suite: {(nights * 89):f2} lv.");
                }

            }
        }
    }


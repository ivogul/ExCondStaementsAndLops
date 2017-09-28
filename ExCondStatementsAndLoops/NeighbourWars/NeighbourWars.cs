using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int turn = 0;
            int peshoHealth = 100;
            int goshoHealth = 100;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    turn++;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    if (i % 3 == 0)
                    {
                        goshoHealth += 10;
                        peshoHealth += 10;
                    }
                }
                else if (i % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    turn++;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    if (i % 3 == 0)
                    {
                        goshoHealth += 10;
                        peshoHealth += 10;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Again
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string[] Comands = Console.ReadLine().Split(" ").ToArray();

            int LenghtHouses = houses.Count;

            int currentHouse = 0;


            while (Comands[0] != "Love!")
            {
                int Jump = int.Parse(Comands[1]);

                if (Jump + currentHouse < houses.Count)
                {
                    houses[Jump + currentHouse] -= 2;
                    if (houses[Jump + currentHouse]==0)
                    {                  
                        Console.WriteLine($"Place {Jump+currentHouse} has Valentine's day.");
                    }
                    else if (houses[Jump + currentHouse] < 0)
                    {
                        Console.WriteLine($"Place {Jump + currentHouse} already had Valentine's day.");
                    }
                    currentHouse += Jump;                  
                }
                else
                {
                    houses[0] -= 2;
                    if (houses[0] == 0)
                    {
                        Console.WriteLine($"Place {0} has Valentine's day.");
                    }
                    else if (houses[0]<0)
                    {
                        Console.WriteLine($"Place {0} already had Valentine's day.");
                    }
                    currentHouse = 0;
                }

                Comands = Console.ReadLine().Split(" ").ToArray();
            }
           
            Console.WriteLine($"Cupid's last position was {currentHouse}.");

            int count = 0;

            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Cupid has failed {count} places.");

        }
    }
    }


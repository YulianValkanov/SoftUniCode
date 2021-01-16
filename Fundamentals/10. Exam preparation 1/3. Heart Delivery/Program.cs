using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string[] Comands = Console.ReadLine().Split(" ").ToArray();

            int LenghtHouses = houses.Count;

            int currentHouse = 0;

            while (Comands[0]!= "Love!")
            {
                int Jump = int.Parse(Comands[1]);

                if (Jump+currentHouse<houses.Count)
                {
                    houses[Jump+currentHouse] -= 2;
                    currentHouse += Jump;


                }
                else
                {
                    houses[0] -= 2;
                    currentHouse = 0;
                }

                

               


                Comands= Console.ReadLine().Split(" ").ToArray();
            }
            Console.WriteLine(string.Join(" ",houses));
            
        }
    }
}

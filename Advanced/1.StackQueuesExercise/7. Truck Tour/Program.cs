using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int PumpsCount = int.Parse(Console.ReadLine());
            Queue<string> pumpsData = new Queue<string>();

            for (int i = 0; i < PumpsCount; i++)
            {
                pumpsData.Enqueue(Console.ReadLine());
            }

           

            for (int i = 0; i < PumpsCount; i++)
            {
                int currentPetrolAmmount = 0;
                bool isSuxessfull = true;
                for (int j = 0; j < PumpsCount; j++)
                {
                    int[] pumpData = pumpsData.Dequeue().Split(" ").Select(int.Parse).ToArray();
                    pumpsData.Enqueue(string.Join(" ", pumpData));
                    currentPetrolAmmount += pumpData[0];
                    currentPetrolAmmount -= pumpData[1];

                    if (currentPetrolAmmount<0)
                    {
                        isSuxessfull = false;
                    }
                }
                if (isSuxessfull)
                {
                    Console.WriteLine(i);
                    break;
                }

                string tempData = pumpsData.Dequeue();
                pumpsData.Enqueue(tempData);
            }
        }
    }
}

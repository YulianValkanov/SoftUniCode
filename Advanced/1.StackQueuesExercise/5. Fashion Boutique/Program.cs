using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allClodesInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> allClodes = new Stack<int>(allClodesInput);

            int boxCapaciti = int.Parse(Console.ReadLine());
            int currentBoxCapacity = boxCapaciti;
            int countBox = 1; //???

            while (allClodes.Any())
            {
                int clothes = allClodes.Pop();

                currentBoxCapacity -= clothes;

                if (currentBoxCapacity<0)
                {
                    countBox ++;
                    currentBoxCapacity = boxCapaciti - clothes;
                }
            }

            Console.WriteLine(countBox);


        }
    }
}

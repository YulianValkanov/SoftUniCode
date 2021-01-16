using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());

            List<int> currentState = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i < currentState.Count; i++)
            {
                int currentCabinCount = currentState[i];

                int currentCabinSpace = 4 - currentCabinCount;

                for (int j = currentCabinCount; j < 4; j++)
                {
                    peopleWaiting -= 1;


                    currentState[i] += 1;
                    if (peopleWaiting <= 0)
                    {
                        break;
                    }

                }

            }
            bool isFull = false;
            for (int i = 0; i < currentState.Count; i++)
            {
                if (currentState[i]==4)
                {
                    isFull = true;
                }
                else
                {
                    isFull = false;
                }
            }

            if (peopleWaiting==0&&isFull==false)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", currentState));
            }
            else if (peopleWaiting>0&&isFull==true)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", currentState));
            }
            else if (isFull=true&&peopleWaiting==0)
            {
                Console.WriteLine(string.Join(" ", currentState));
            }
            
        }
    }
}

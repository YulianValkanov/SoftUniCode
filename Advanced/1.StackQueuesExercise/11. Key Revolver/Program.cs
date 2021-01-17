using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunbarrelSize = int.Parse(Console.ReadLine());

            int[] bulletsInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(bulletsInput);

            int[] locksInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(locksInput);

            int inteligenceValue = int.Parse(Console.ReadLine());

            int bulletsCount = 0;
            int currgunGarrelSize = gunbarrelSize;
            

            while (bullets.Any()&&locks.Any())
            {
                
                int currBullet = bullets.Pop();
                int currLock= locks.Peek();
                bulletsCount ++;
                currgunGarrelSize--;

                 
             


                if (currBullet<=currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (currgunGarrelSize == 0&&bullets.Any())
                {
                    currgunGarrelSize = gunbarrelSize;
                    Console.WriteLine("Reloading!");
                }
            }
            if (!locks.Any())
            {
                int moneyEarnded = inteligenceValue - (bulletsCount * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarnded}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}

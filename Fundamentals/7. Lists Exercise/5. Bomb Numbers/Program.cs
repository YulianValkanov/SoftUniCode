using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int[] bombProop = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int bomb = bombProop[0];

            int power = bombProop[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber==bomb)
                {
                    int startIndex = i - power;

                    int endIndex = i + power;

                    if (startIndex<0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex>numbers.Count-1)
                    {
                        endIndex = numbers.Count - 1;
                    }

                    int endIndexToRemove = endIndex - startIndex + 1;

                    numbers.RemoveRange(startIndex, endIndexToRemove);

                    i = startIndex - 1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}

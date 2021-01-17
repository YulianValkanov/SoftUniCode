using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = first[0];
            int s = first[1];
            int x = first[2];

            int[] numbersInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(numbersInput[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }

    }
}

using System;

using System.Collections.Generic;
using System.Linq;

namespace _1.StackQueuesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first= Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = first[0];
            int s = first[1];
            int x = first[2];

            int[] numbersInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Push(numbersInput[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }

            bool isFound = numbers.Contains(x);

          

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else if (!numbers.Any())
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

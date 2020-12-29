using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            List<int> SecondNumber = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToList();

            List<int> Result = new List<int>();

            for (int i = 0; i < Math.Min(numbers.Count, SecondNumber.Count); i++)
            {
                Result.Add(numbers[i]);
                Result.Add(SecondNumber[i]);
            }

            for (int i = Math.Min(numbers.Count, SecondNumber.Count); i < Math.Max(numbers.Count, SecondNumber.Count); i++)
            {
                if (i >= numbers.Count)
                {
                    Result.Add(SecondNumber[i]);
                }
                else
                {
                    Result.Add(numbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ",Result));
        }
    }
}

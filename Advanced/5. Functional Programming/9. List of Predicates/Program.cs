using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            List<int> dividers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> numbers = (Enumerable.Range(1, end)). ToList();

            Func<int, int, bool> predicate = (num, d) => num % d == 0;

            foreach (var num in numbers)
            {
               // if (dividers.All(d=>num%d==0))
               if(dividers.All(d=>predicate(num,d)))
                {
                    Console.Write(num+" ");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine().Split(" ");

            Queue<string> people = new Queue<string>(Input);

            int n = int.Parse(Console.ReadLine());

            int Count = 0;
            while (people.Count!=1)
            {
                Count++;

                string kid = people.Dequeue();

                if (Count==n)
                {
                    Count = 0;
                    Console.WriteLine($"Removed {kid}");
                }
                else
                {
                    people.Enqueue(kid);
                }
            }

            Console.WriteLine($"Last is {string.Join("",people)}");
        }
    }
}

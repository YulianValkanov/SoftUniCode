using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else
                {
                    numbers[number]++;
                }
            }


            /// Dictionary<int, int> evenCounts = numbers.Where(x => x.Value % 2 == 0).ToDictionary(x=>x.Key,x=>x.Value);

            //// Console.WriteLine(evenCounts.First().Value);
            ///
            Console.WriteLine(numbers.First(x => x.Value % 2 == 0).Key); 
        }
    }
}

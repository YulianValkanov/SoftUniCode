using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = input[0];
            int m = input[1];

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();


            for (int i = 0; i < n; i++)
            {
                int currNumbers = int.Parse(Console.ReadLine());

                first.Add(currNumbers);
            }

            for (int i = 0; i < m; i++)
            {
                int currNumbers = int.Parse(Console.ReadLine());

                second.Add(currNumbers);
            }

            HashSet<int> end = new HashSet<int>();


            foreach (var element in first)
            {

              
                foreach (var item in second)
                {

                    if (element==item)
                    {
                        end.Add(element);
                    }

                }
            }

            Console.WriteLine(string.Join(" ",end));
        }
    }
}

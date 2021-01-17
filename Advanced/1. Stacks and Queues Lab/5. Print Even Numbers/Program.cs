using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i]%2==0)
                {
                    numbers.Enqueue(Input[i]);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

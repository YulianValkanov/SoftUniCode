using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] comands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                if (comands[0]==1)
                {
                    numbers.Push(comands[1]);
                }
                else if (comands[0]==2)
                {
                    if (numbers.Count>0)
                    {
                        numbers.Pop();
                    }
                    
                }
                else if (comands[0]==3)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (comands[0]==4)
                {
                    Console.WriteLine(numbers.Min());
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

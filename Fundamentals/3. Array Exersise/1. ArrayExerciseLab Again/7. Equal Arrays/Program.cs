using System;
using System.Linq;

namespace _7._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayFirst = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] ArraySecond = Console.ReadLine()
           .Split(" ")
           .Select(int.Parse)
           .ToArray();

            int sum = 0;
            bool isEqual = true;

            for (int i = 0; i < ArrayFirst.Length; i++)
            {
                if (ArrayFirst[i]==ArraySecond[i])
                {
                    sum += ArrayFirst[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical.Found difference at {i} index");
                    isEqual = false;
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical.Sum: {sum}");
            }
        }
    }
}

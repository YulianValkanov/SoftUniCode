using System;
using System.Linq;

namespace _8._MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < Numbers.Length; i++)
            {
                int CurrentElement = Numbers[i];

                int SecondElement = 0;

                for (int j = i+1; j < Numbers.Length; j++)
                {
                    if (CurrentElement+Numbers[j]==n)
                    {
                        SecondElement = Numbers[j];

                        Console.WriteLine(($"{ CurrentElement} {SecondElement}"));
                    }
                }

                
            }
        }
    }
}

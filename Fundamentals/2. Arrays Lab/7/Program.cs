using System;
using System.Linq;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Num = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < Num.Length; i++)
            {
                Console.WriteLine($"{Num[i]} => {Math.Round(Num[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

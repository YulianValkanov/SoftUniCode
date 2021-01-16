using System;
using System.Collections.Generic;
using System.Linq;




namespace _5._Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            int macIndex = numbers.Count / 2;

            int originalCount = numbers.Count;

            for (int i = 0; i < macIndex; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.Remove(numbers[numbers.Count - 1]);
            }

            Console.WriteLine(string.Join(" ",numbers));

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ASSOCIATIVE_ARRAYS_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] imput = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            foreach (var number in imput)
            {
                if (numbers.ContainsKey(number))
                {
                    numbers[number]+=1;
                }
                else
                {
                    numbers.Add(number,1); 
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine($"{numbers.Keys} ->{numbers.Values}");
            }
        }
    }
}

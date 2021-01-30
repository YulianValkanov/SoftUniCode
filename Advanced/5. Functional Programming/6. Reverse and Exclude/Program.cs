using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<List<int>> print = x => Printer(x);

            

            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            numbers.Reverse();

            Predicate<int> predicate = x => x % n != 0;

            numbers = MyWhere(numbers, predicate);

            print(numbers);
        }

        private static void Printer(List<int> num)
        {
            Console.WriteLine(string.Join(" ", num));
        }

        private static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    newNumbers.Add(number);
                }

               
            }
            return newNumbers;
        }
    }
}

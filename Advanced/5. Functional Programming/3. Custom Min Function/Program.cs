using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<List<int>, int> action = x =>
             {
                 int minNum = int.MaxValue;
                 foreach (var item in x)
                 {
                     if (item < minNum)
                     {
                         minNum = item;
                     }
                 }
                


                 return minNum;
             };

            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int newNumber = action(numbers);

            Console.WriteLine(newNumber);
         

            
        }
    }
}

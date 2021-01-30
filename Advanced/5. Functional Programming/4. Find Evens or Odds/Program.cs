using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int start = ranges[0];
            int end = ranges[1];

            string criteria = Console.ReadLine();

            Func<int, int, List<int>> generateRangeOfNums = (s, e) =>
          {
              List<int> nums = new List<int>();

              for (int i = s; i <= e; i++)
              {
                  nums.Add(i);
              }

              return nums; ;
          };


            

            Predicate<int> predicate = n => true;

            if (criteria=="odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (criteria=="even")
            {
                predicate = n => n % 2 == 0;
            }

            Console.WriteLine(string.Join(" ", MyWheree( generateRangeOfNums(start, end), predicate)));
        }

        static List<int> MyWheree (List<int> numers, Predicate<int> predicate)
        {
            List<int> numbers = new List<int>();

            foreach (var CurrNum in numers)
            {
                if (predicate(CurrNum))
                {
                    numbers.Add(CurrNum);
                }
            }

                

            return numbers;
        }
    }
}

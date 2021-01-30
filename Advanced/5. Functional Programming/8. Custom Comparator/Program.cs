using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InputNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Array.Sort(InputNumbers);

            Func<int[], List<int>> funOEvenOdd = x =>
              {


                  List<int> numbers = new List<int>();

                  for (int i = 0; i < x.Length; i++)
                  {
                      if (x[i] % 2 == 0)
                      {
                          numbers.Add(InputNumbers[i]);
                      }
                  }
                  for (int i = 0; i < x.Length; i++)
                  {
                      if (x[i] % 2 != 0)
                      {
                          numbers.Add(x[i]);
                      }
                  }

                  return numbers;
              };

            Console.WriteLine(String.Join(" ", funOEvenOdd(InputNumbers)));

        }

        private static List<int> EvenOddMethood(int[] inputNumbers)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] % 2 == 0)
                {
                    numbers.Add(inputNumbers[i]);
                }
            }
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] % 2 != 0)
                {
                    numbers.Add(inputNumbers[i]);
                }
            }

            ///Console.WriteLine(string.Join(" ", numbers));
            return numbers;
        }
    }
}
